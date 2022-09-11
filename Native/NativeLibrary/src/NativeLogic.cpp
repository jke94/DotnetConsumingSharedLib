#include "NativeLogic.h"

namespace NativeLibrary
{
    NativeLogic::NativeLogic()
    {
    }

    NativeLogic::~NativeLogic()
    {
    }

    bool NativeLogic::process_input(const settings& settings, result* result)
    {
        result->count = settings.count_accepted + 3;
        return true;
    }
}
