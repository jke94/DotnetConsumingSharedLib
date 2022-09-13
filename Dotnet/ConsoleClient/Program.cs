namespace ConsoleClient
{
    #region using

    using NativeWrapper;

    #endregion

    public class Program
    {
        public static void Main()
        {
            byte[] array_bytes = { 97, 98, 99 , 100, 101, 102};

            Settings mySettings;

            mySettings.input_path = "TheInputPath";
            mySettings.first_file = "FirstFile";
            mySettings.second_file = "SecondFile";
            mySettings.mask = "TheMask";
            mySettings.log_path = "LogPath";
            mySettings.count_accepted = 1994;
            mySettings.confidence = 1994.1994;
            mySettings.device = "TheDevice";

            Result myResult;

            myResult.count = 0;
            myResult.is_preprocessed = false;
            myResult.duration = 0.0;

            Console.WriteLine($"[Before] myResult.count: {myResult.count}");
            Console.WriteLine($"[Before] myResult.duration: {myResult.duration}");

            var resultA = LibWrapper.ProcessInput(ref mySettings, out myResult);

            Console.WriteLine($"ProcessInput, resultA: {resultA}");
            Console.WriteLine($"[After] myResult.count: {myResult.count}");
            Console.WriteLine($"[After] myResult.duration: {myResult.duration}");

            var resultB = LibWrapper.ProcessingData(array_bytes, (uint)array_bytes.Length);

            Console.WriteLine($"ProcessingData, resultB: {resultB}");
        }
    }
}