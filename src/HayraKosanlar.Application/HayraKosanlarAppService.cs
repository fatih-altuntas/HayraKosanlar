using System;
using System.Collections.Generic;
using System.Text;
using HayraKosanlar.Localization;
using Volo.Abp.Application.Services;

namespace HayraKosanlar
{
    /* Inherit your application services from this class.
     */
    public abstract class HayraKosanlarAppService : ApplicationService
    {
        protected HayraKosanlarAppService()
        {
            LocalizationResource = typeof(HayraKosanlarResource);
        }
    }
}
