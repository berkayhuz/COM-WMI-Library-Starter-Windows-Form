#include "com_wmi.h"
#include <comdef.h>
#include <atlbase.h>
#include <Wbemidl.h>
#include <string>
#include <sstream>
#include <stdexcept>
#include <codecvt>
#include <locale>
#pragma comment(lib, "wbemuuid.lib")

static bool comInitialized = false;
static bool wmiInitialized = false;
static IWbemLocator* pLocator = NULL;
static IWbemServices* pSvc = NULL;

std::wstring GetErrorMessage(HRESULT hr) {
    _com_error err(hr);
    _bstr_t bstrError(err.ErrorMessage());
    return static_cast<std::wstring>(bstrError);
}

extern "C" __declspec(dllexport) const wchar_t* InitializeCOM_Utf16() {
    static std::wstring result;

    if (comInitialized) {
        result = L"COM is already initialized.";
        return result.c_str();
    }

    HRESULT hr = CoInitialize(NULL);
    if (FAILED(hr)) {
        result = L"Failed to initialize COM with CoInitialize: " + GetErrorMessage(hr);
        comInitialized = false;
        return result.c_str();
    }

    result = L"COM initialized successfully.";
    comInitialized = true;
    return result.c_str();
}

extern "C" __declspec(dllexport) const wchar_t* UninitializeCOM_Utf16() {
    static std::wstring result;
    if (comInitialized) {
        CoUninitialize();
        comInitialized = false;
        result = L"COM uninitialized successfully.";
    }
    else {
        result = L"COM was not initialized.";
    }
    return result.c_str();
}

extern "C" __declspec(dllexport) const wchar_t* InitializeWMI_Utf16() {
    static std::wstring result;

    if (!comInitialized) {
        result = L"Error: COM is not initialized. Please initialize COM first.";
        return result.c_str();
    }

    if (wmiInitialized) {
        result = L"WMI is already initialized.";
        return result.c_str();
    }

    HRESULT hr = CoCreateInstance(
        CLSID_WbemLocator,
        NULL,
        CLSCTX_INPROC_SERVER,
        IID_IWbemLocator,
        (void**)&pLocator
    );

    if (FAILED(hr)) {
        result = L"Failed to create WMI locator: " + GetErrorMessage(hr);
        return result.c_str();
    }

    hr = pLocator->ConnectServer(
        _bstr_t(L"ROOT\\CIMV2"),
        NULL,
        NULL,
        NULL,
        0,
        NULL,
        NULL,
        &pSvc
    );

    if (FAILED(hr)) {
        result = L"Failed to connect to WMI server: " + GetErrorMessage(hr);
        pLocator->Release();
        pLocator = NULL;
        return result.c_str();
    }

    wmiInitialized = true;
    result = L"WMI initialized successfully.";
    return result.c_str();
}

extern "C" __declspec(dllexport) const wchar_t* UninitializeWMI_Utf16() {
    static std::wstring result;
    if (wmiInitialized) {
        if (pSvc) {
            pSvc->Release();
            pSvc = NULL;
        }
        if (pLocator) {
            pLocator->Release();
            pLocator = NULL;
        }
        wmiInitialized = false;
        result = L"WMI uninitialized successfully.";
    }
    else {
        result = L"WMI was not initialized.";
    }
    return result.c_str();
}
