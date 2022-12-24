using Microsoft.EntityFrameworkCore;
using SearchPrimeNumbers.Data.Tables;

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
