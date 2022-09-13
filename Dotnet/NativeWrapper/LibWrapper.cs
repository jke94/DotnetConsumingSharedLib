namespace NativeWrapper
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct DataArray
    {
        [MarshalAs(UnmanagedType.I4)]
        public int size;

        [MarshalAs(UnmanagedType.ByValArray)]
        public byte[] data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Settings
    {
        [MarshalAs(UnmanagedType.LPStr)]
        public string input_path;

        [MarshalAs(UnmanagedType.LPStr)]
        public string first_file;

        [MarshalAs(UnmanagedType.LPStr)]
        public string second_file;

        [MarshalAs(UnmanagedType.LPStr)]
        public string mask;

        [MarshalAs(UnmanagedType.LPStr)]
        public string log_path;

        [MarshalAs(UnmanagedType.I4)]
        public int count_accepted;

        [MarshalAs(UnmanagedType.R8)]
        public double confidence;
        
        [MarshalAs(UnmanagedType.LPStr)]
        public string device;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Result
    {
        [MarshalAs(UnmanagedType.I4)]
        public int count;

        [MarshalAs(UnmanagedType.I1)]
        public bool is_preprocessed;
        
        [MarshalAs(UnmanagedType.R8)]
        public double duration;
    }

    public class LibWrapper
    {
        [DllImport("libNativeLibrary.so", 
            EntryPoint = "process_input", 
            CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.I1)]
        public static extern bool ProcessInput(ref Settings settings, out Result result);

        [DllImport("libNativeLibrary.so", 
            EntryPoint = "processing_data", 
            CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ProcessingData([In][MarshalAs(UnmanagedType.LPArray)] byte[] data, uint length);
    }
}