using SearchPrimeNumbers.Service;
using System.Diagnostics;

namespace SearchPrimeNumbers
{
    public static class SearchPrimeNumbers
    {
        private static Stopwatch stopwatch { get; set; } = new Stopwatch(); 
        public static void Main(string[] args)
        {
            stopwatch.Start();

            RunCode();

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadLine();
        }


        private static void RunCode()
        {
            // I want find all primary numbers at from/to range.
            // Right away skiping all even numbers
            for (int testingNumber = Config.From; testingNumber <= Config.To; testingNumber += 2)
            {

                // Doesn't make sense brute forcing numbers after root of testing number
                int bruteForceTo = (int)Math.Round(Math.Sqrt(testingNumber));

                bool primaryFlag = true;

                // Again skip even numbers
                for (int i = 3; i <= bruteForceTo; i += 2)
                {
                    if (testingNumber % i == 0)
                    {
                        primaryFlag = false;
                        break;
                    }
                }

                if (primaryFlag) Logger.Log(testingNumber.ToString());
            }

        }
    }
}