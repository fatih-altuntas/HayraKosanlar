using HayraKosanlar.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HayraKosanlar.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class HayraKosanlarController : AbpController
    {
        protected HayraKosanlarController()
        {
            LocalizationResource = typeof(HayraKosanlarResource);
        }
    }
}