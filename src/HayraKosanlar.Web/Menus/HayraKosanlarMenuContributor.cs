using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using HayraKosanlar.Localization;
using HayraKosanlar.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace HayraKosanlar.Web.Menus
{
    public class HayraKosanlarMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<HayraKosanlarResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(HayraKosanlarMenus.Home, l["Menu:Home"], "~/"));
            context.Menu.AddItem(
                new ApplicationMenuItem(
                "HelpRequests",
                l["Menu:HelpRequests"],
                icon: "fa fa-book",
                url: "/HelpRequest"
            )
        );
        }
    }
}
