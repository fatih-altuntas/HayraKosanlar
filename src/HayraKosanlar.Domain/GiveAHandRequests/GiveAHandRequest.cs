using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HayraKosanlar.GiveAHandRequests
{
    public class GiveAHandRequest : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string ExtraInformation { get; set; }
    }
}
