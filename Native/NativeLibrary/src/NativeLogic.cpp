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
        result->duration = 1994.1994 + 1.0001;

        std::cout << "Data:" << settings.dataArray.data << std::endl;

        for (int i=0; i<settings.dataArray.size; i++)
        {
            std::cout << "Data [" << i << "]: " <<
                (char)settings.dataArray.data[i] << std::endl;
        }

        return true;
    }
}
