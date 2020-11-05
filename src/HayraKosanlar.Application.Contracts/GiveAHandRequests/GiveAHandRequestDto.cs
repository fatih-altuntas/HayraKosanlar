using System;
using Volo.Abp.Application.Dtos;

namespace HayraKosanlar.GiveAHandRequests
{
    public class GiveAHandRequestDto: AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string ExtraInformation { get; set; }
    }
}
