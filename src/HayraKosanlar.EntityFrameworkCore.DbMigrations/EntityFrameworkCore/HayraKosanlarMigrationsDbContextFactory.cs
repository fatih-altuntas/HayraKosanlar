using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HayraKosanlar.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class HayraKosanlarMigrationsDbContextFactory : IDesignTimeDbContextFactory<HayraKosanlarMigrationsDbContext>
    {
        public HayraKosanlarMigrationsDbContext CreateDbContext(string[] args)
        {
            HayraKosanlarEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<HayraKosanlarMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new HayraKosanlarMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../HayraKosanlar.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
