using HayraKosanlar.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HayraKosanlar.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class HayraKosanlarPageModel : AbpPageModel
    {
        protected HayraKosanlarPageModel()
        {
            LocalizationResourceType = typeof(HayraKosanlarResource);
        }
    }
}