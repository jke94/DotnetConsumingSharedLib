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

        return true;
    }
    
    bool NativeLogic::processing_data(uint8_t data, uint32_t length)
    {
        std::cout << "Size (bytes): " << length << std::endl;
        std::vector<uint8_t>vector(length);
        memcpy(&vector[0], &data, length * sizeof(uint8_t));

        std::cout << "Message from native code, length: " << length << std::endl;
        return true;
    }
}
