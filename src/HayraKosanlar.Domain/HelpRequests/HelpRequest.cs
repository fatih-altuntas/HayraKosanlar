using HayraKosanlar.HelpRequest;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HayraKosanlar.HelpRequests
{
    public class HelpRequest : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
        public long TownId { get; set; }
        public string Birthplace { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string PhoneNumber { get; set; }
        public string EducationLevel { get; set; }
        public string Job { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string PartnerName { get; set; }
        public long ChildrenCount { get; set; }
        public string ExtraInformation { get; set; }
        public HelpRequestStatus Status { get; set; }
    }
}
