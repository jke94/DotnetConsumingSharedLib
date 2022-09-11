#include "NativeLogic.h"

#ifdef defined(_MSC_VER)
    // Microsoft
    #define NATIVE_LIBRARY_API __declspec(dllexport)
#elif defined(__GNUC__)
    // GCC
    #define NATIVE_LIBRARY_API __attribute__((visibility("default")))
#else
    #define NATIVE_LIBRARY_API

#endif

extern "C"
{
    using namespace NativeLibrary;

    bool NATIVE_LIBRARY_API process_input(const settings& settings, result* result);
}