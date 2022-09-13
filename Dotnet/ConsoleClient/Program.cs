namespace ConsoleClient
{
    using NativeWrapper;
    using System.Runtime.InteropServices;

    public class Program
    {
        public static void Main()
        {
            byte[] array_bytes = { 97, 98, 99 , 100, 101, 102};

            DataArray dataArray;
            dataArray.size = array_bytes.Length;
            dataArray.data = array_bytes;

            Settings mySettings;

            mySettings.input_path = "TheInputPath";
            mySettings.first_file = "FirstFile";
            mySettings.second_file = "SecondFile";
            mySettings.mask = "TheMask";
            mySettings.log_path = "LogPath";
            mySettings.count_accepted = 1994;
            mySettings.confidence = 1994.1994;
            mySettings.device = "TheDevice";
            mySettings.dataArray = dataArray;

            Result myResult;

            myResult.count = 0;
            myResult.is_preprocessed = false;
            myResult.duration = 0.0;

            Console.WriteLine($"dataArray.size: {dataArray.size}");
            Console.WriteLine($"[Before] myResult.count: {myResult.count}");
            Console.WriteLine($"[Before] myResult.duration: {myResult.duration}");
            var result = LibWrapper.ProcessInput(
                ref mySettings, out myResult);

            Console.WriteLine($"ProcessInput: {result}");

            Console.WriteLine($"[After] myResult.count: {myResult.count}");
            Console.WriteLine($"[After] myResult.duration: {myResult.duration}");
        }
    }
}