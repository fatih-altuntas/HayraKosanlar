using HayraKosanlar.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace HayraKosanlar
{
    [DependsOn(
        typeof(HayraKosanlarEntityFrameworkCoreTestModule)
        )]
    public class HayraKosanlarDomainTestModule : AbpModule
    {

    }
}