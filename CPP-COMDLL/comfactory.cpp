#include <windows.h>
#include "com_wmi.h"

BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved) {
    switch (ul_reason_for_call) {
    case DLL_PROCESS_ATTACH:
        InitializeCOM_Utf16();
        InitializeWMI_Utf16();
        break;
    case DLL_PROCESS_DETACH:
        UninitializeWMI_Utf16();
        UninitializeCOM_Utf16();
        break;
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
        break;
    }
    return TRUE;
}
