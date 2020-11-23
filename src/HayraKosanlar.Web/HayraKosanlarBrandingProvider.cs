using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace HayraKosanlar.Web
{
    [Dependency(ReplaceServices = true)]
    public class HayraKosanlarBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Kocaeli Yardım Severler";
    }
}
