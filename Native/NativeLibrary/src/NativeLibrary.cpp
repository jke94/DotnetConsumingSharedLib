#include "NativeLibrary.h"

#if defined(_MSC_VER)

    // Microsoft

    BOOL APIENTRY DllMain(
        HMODULE hModule,
        DWORD ul_reason_for_call,
        LPVOID lpReserved
    )
    {
        switch (ul_reason_for_call)
        {
            case DLL_PROCESS_ATTACH:
            // Initialize once for each new process.
            // Return FALSE to fail DLL load.
                break;

            case DLL_THREAD_ATTACH:
            // Do thread-specific initialization.
                break;

            case DLL_THREAD_DETACH:
            // Do thread-specific cleanup.
                break;

            case DLL_PROCESS_DETACH:
            
                if (lpvReserved != nullptr)
                {
                    break; // do not do cleanup if process termination scenario
                }
                
            // Perform any necessary cleanup.
                break;
        }
    }

#endif

NativeLogic native_logic;

bool NATIVE_LIBRARY_API process_input(const settings& settings, result* result)
{
    native_logic.process_input(settings, result);
}