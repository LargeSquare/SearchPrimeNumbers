namespace SearchPrimeNumbers.Service
{
    internal class Logger
    {
        private static string filePath { get; set; } = AppDomain.CurrentDomain.BaseDirectory + "primeNumbers.txt";
        private static StreamWriter streamWriter { get; set; } = new StreamWriter(filePath);
        public static void Log(string message)
        {
            message = DateTime.Now.ToString() + " : " + message;

            streamWriter.WriteLine(message);
        }
    }
}
