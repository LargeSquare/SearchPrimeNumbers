using SearchPrimeNumbers.Service;

namespace SearchPrimeNumbers
{
    public static class SearchPrimeNumbers
    {
        private static List<int> primeNumbers { get; set; } = new List<int>(); 
        public static void Main(string[] args)
        {

            // I want find all primary numbers at from/to range.
            // Right away skiping all even numbers
            for (int testingNumber = Config.From; testingNumber <= Config.To; testingNumber += 2)
            {

                // Doesn't make sense brute forcing numbers after root of testing number
                int bruteForceTo = (int) Math.Round(Math.Sqrt(testingNumber));

                bool primaryFlag = true;

                // Again skip even numbers
                for(int i = 3; i <= bruteForceTo; i += 2)
                {
                    if(testingNumber % i == 0)
                    {
                        primaryFlag = false;
                        break;
                    }
                }

                if(primaryFlag) primeNumbers.Add(testingNumber);
            }


            foreach(int number in primeNumbers) Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}