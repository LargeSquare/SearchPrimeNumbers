
using System.Numerics;

namespace SearchPrimeNumbers.Service
{
    internal static class Config
    {
        public static int From { get; set; } = 3;
        public static BigInteger To { get; set; } = BigInteger.Parse("800000000");
        //public static BigInteger To { get; set; } = BigInteger.Parse("39020571855401265608465770302117235537201395138561");
    }
}
