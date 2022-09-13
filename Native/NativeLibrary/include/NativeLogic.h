#include <iostream>
#include <vector>
#include <stdio.h>
#include <string.h>

namespace NativeLibrary
{
    struct dataArray
    {
        int size;
        char data[];
    };
    
    struct settings
    {
        char* input_path;
        char* first_file;
        char* second_file;
        char* mask;
        char* log_path;
        int count_accepted;
        double confidence;
        char* device;
        struct dataArray dataArray;
    };

    struct result
    {
        int count;
        // foo* foos;
        bool is_preprocessed;
        double duration;
    };

    class NativeLogic
    {
    private:
        /* data */
    public:
        NativeLogic(/* args */);
        ~NativeLogic();
        bool processing_data(uint8_t data, uint32_t length);
        bool process_input(const settings& settings, result* result);
    };
}
