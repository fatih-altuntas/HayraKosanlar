using Volo.Abp.Modularity;

namespace HayraKosanlar
{
    [DependsOn(
        typeof(HayraKosanlarApplicationModule),
        typeof(HayraKosanlarDomainTestModule)
        )]
    public class HayraKosanlarApplicationTestModule : AbpModule
    {

    }
}