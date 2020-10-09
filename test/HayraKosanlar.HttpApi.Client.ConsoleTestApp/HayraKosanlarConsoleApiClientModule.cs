using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace HayraKosanlar.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(HayraKosanlarHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class HayraKosanlarConsoleApiClientModule : AbpModule
    {
        
    }
}
