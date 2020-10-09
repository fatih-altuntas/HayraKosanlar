using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace HayraKosanlar.EntityFrameworkCore
{
    [DependsOn(
        typeof(HayraKosanlarEntityFrameworkCoreModule)
        )]
    public class HayraKosanlarEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<HayraKosanlarMigrationsDbContext>();
        }
    }
}
