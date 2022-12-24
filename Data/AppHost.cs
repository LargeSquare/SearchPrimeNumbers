using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SearchPrimeNumbers.Data
{
    /// <summary>
    /// This class designed for encapsulation database creation process
    /// </summary>
    internal class AppHost
    {
        private static IHostBuilder hostBuilder { get; set; }
        private static IHost host { get; set; }
        public static DatabaseModel DB { get; private set; }


        /// <summary>
        /// Implements the process of initializing a database connection through the c# interfaces: IHost, IHostBuilder
        /// </summary>
        /// <param name="args">Application input arguments</param>
        /// <param name="connectionString">Title of the connection string from the config file</param>
        /// <returns>Return database context instance</returns>
        public static DatabaseModel Init(string[] args, string connectionString)
        {
            hostBuilder = Host.CreateDefaultBuilder(args);


            hostBuilder.ConfigureAppConfiguration((config) =>
            {
                config.AddJsonFile("appsettings.json");
                config.AddEnvironmentVariables();
                config.Build();
            });


            hostBuilder.ConfigureServices((context, services) =>
            {
                var ConnectionString = context.Configuration.GetConnectionString(connectionString);
                services.AddDbContext<DatabaseModel>(options => options.UseSqlite(ConnectionString))
                ;
            });



            host = hostBuilder.Build();

            DB = host.Services.CreateScope().ServiceProvider.GetRequiredService<DatabaseModel>();

            return DB;
        }
    }
}
