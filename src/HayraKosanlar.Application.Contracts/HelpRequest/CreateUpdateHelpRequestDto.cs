using System.ComponentModel.DataAnnotations;

namespace HayraKosanlar.HelpRequest
{
    public class CreateUpdateHelpRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [Range(10000000000,99999999999,ErrorMessage = "Please enter your 11-digit ID number")]
        public string IdentityNumber { get; set; }
        [Required]
        public long TownId { get; set; }
        [Required]
        public string Birthplace { get; set; }
        [Required]
        public string MotherName { get; set; }
        [Required]
        public string FatherName { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
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
