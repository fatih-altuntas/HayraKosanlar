using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace HayraKosanlar.GiveAHandRequests
{
    public class CreateUpdateGiveAHandRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Required]
        public string PhoneNumber { get; set; }
        public string ExtraInformation { get; set; }
    }
}
