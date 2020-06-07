using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Solution.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class SolutionMigrationsDbContextFactory : IDesignTimeDbContextFactory<SolutionMigrationsDbContext>
    {
        public SolutionMigrationsDbContext CreateDbContext(string[] args)
        {
            SolutionEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SolutionMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new SolutionMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
