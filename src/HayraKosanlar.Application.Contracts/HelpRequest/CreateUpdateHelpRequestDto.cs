using HayraKosanlar.HelpRequest;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HayraKosanlar.HelpRequest
{
    public class CreateUpdateHelpRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string IdentityNumber { get; set; }
        [Required]
        public long TownId { get; set; }
        [Required]
        public string Birthplace { get; set; }
        [Required]
        public string MotherName { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string EducationLevel { get; set; }
        [Required]
        public string Job { get; set; }
        [Required]
        public MaritalStatus MaritalStatus { get; set; }
        public string PartnerName { get; set; }

        [Required]
        public long ChildrenCount { get; set; }
        public string ExtraInformation { get; set; }

        [Required]
        public HelpRequestStatus Status { get; set; } = HelpRequestStatus.NewRequest;
    }
}
