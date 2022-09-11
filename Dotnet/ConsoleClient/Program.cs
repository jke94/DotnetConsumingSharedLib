namespace ConsoleClient
{
    using NativeWrapper;

    public class Program
    {
        public static void Main()
        {
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

            var result = LibWrapper.ProcessInput(
                ref mySettings, out myResult);

            Console.WriteLine($"ProcessInput: {result}");

            Console.WriteLine("Hello world!");
        }
    }
}