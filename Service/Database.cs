using SearchPrimeNumbers.Data;
using System.Data.Common;

namespace SearchPrimeNumbers.Service
{
    internal class Database
    {
        internal static DatabaseModel Connection { get; private set; }
    
    
        internal static void Init() 
        {
            DbProviderFactories.RegisterFactory("System.Data.SqlServerCe.4.0", "System.Data.SqlServerCe.SqlCeProviderFactory, System.Data.SqlServerCe, Version=4.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91");
            Connection = new DatabaseModel();
        
        }
    }
}
