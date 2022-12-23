using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SearchPrimeNumbers.Data.Tables
{
    internal class PrimeNumber
    {
        [Key]
        public int Number { get; set; }

        [Required]
        [DefaultValue(0)]
        public int EndOffset { get; set; }
    }
}
