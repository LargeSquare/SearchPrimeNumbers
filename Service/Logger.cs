namespace SearchPrimeNumbers.Service
{
    internal class Logger
    {
        private static string _baseFileName = "log.txt";
        private static string _filePath = baseDir + baseFileName;

        private static string baseDir { get; set; } = AppDomain.CurrentDomain.BaseDirectory;
        public static string baseFileName
        {
            get { return _baseFileName; } 
            set
            {
                if (string.IsNullOrEmpty(value)) throw new NullReferenceException();
                _baseFileName = value;
                filePath = baseDir + _baseFileName;
            }
        }
        private static string filePath
        {
            get { return _filePath; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new NullReferenceException();
                _filePath = value;
                streamWriter = new StreamWriter(_filePath);
            }
        }
        private static StreamWriter streamWriter { get; set; } = new StreamWriter(filePath);
        public static void Log(string message)
        {
            message = DateTime.Now.ToString() + " : " + message;

            streamWriter.WriteLine(message);
        }
    }
}
