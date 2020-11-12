using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace HayraKosanlar.HelpRequests
{
    public class DistributorLookupDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
