using Microsoft.EntityFrameworkCore;
using SearchPrimeNumbers.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPrimeNumbers.Data
{
    internal class DatabaseModel : DbContext
    {
        public DatabaseModel(DbContextOptions<DatabaseModel> options) : base(options)
        {

        }

        public DbSet<PrimeNumber> PrimeNumbers => Set<PrimeNumber>();
    }
}
