namespace ParkingCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   ___           _    _                        \r\n  / _ \\__ _ _ __| | _(_)_ __   __ _            \r\n / /_)/ _` | '__| |/ | | '_ \\ / _` |           \r\n/ ___| (_| | |  |   <| | | | | (_| |           \r\n\\/    \\__,_|_|  |_|\\_|_|_| |_|\\__, |           \r\n                              |___/            \r\n   ___      _            _       _             \r\n  / __\\__ _| | ___ _   _| | __ _| |_ ___  _ __ \r\n / /  / _` | |/ __| | | | |/ _` | __/ _ \\| '__|\r\n/ /__| (_| | | (__| |_| | | (_| | || (_) | |   \r\n\\____/\\__,_|_|\\___|\\__,_|_|\\__,_|\\__\\___/|_|   \r\n                                               ");

            
            
            
            Console.WriteLine($"The parking fee is: {ParkingCalculator.CalculateParkingFee(4)} zł.");
        }
    }
}