﻿
using SearchPrimeNumbers.Data.Tables;
using System.Data.Entity;

namespace SearchPrimeNumbers.Data
{
    internal class DatabaseModel : DbContext
    {
        public DatabaseModel() : base("")
        {

        }

        public DbSet<PrimeNumber> PrimeNumbers { get; set; }
    }
}
