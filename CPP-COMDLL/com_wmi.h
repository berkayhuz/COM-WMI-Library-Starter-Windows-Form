// com_wmi.h
#pragma once

#ifdef COMWMI_EXPORTS
#define COMWMI_API __declspec(dllexport)
#else
#define COMWMI_API __declspec(dllimport)
#endif

extern "C" __declspec(dllexport) const wchar_t* InitializeCOM_Utf16();
extern "C" __declspec(dllexport) const wchar_t* UninitializeCOM_Utf16();
extern "C" __declspec(dllexport) const wchar_t* InitializeWMI_Utf16();
extern "C" __declspec(dllexport) const wchar_t* UninitializeWMI_Utf16();

