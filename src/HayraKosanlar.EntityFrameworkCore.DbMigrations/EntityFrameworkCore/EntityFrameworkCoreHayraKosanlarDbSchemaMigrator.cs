using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HayraKosanlar.Data;
using Volo.Abp.DependencyInjection;

namespace HayraKosanlar.EntityFrameworkCore
{
    public class EntityFrameworkCoreHayraKosanlarDbSchemaMigrator
        : IHayraKosanlarDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreHayraKosanlarDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the HayraKosanlarMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<HayraKosanlarMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}