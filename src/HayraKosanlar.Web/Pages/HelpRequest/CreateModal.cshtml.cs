using HayraKosanlar.HelpRequest;
using HayraKosanlar.HelpRequests;
using HayraKosanlar.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace HayraKosanlar.Web.Pages.HelpRequest
{
    public class CreateModalModel : HayraKosanlarPageModel
    {
        [BindProperty]
        public CreateHelpRequestViewModel HelpRequest { get; set; }
        private readonly IHelpRequestAppService _helpRequestAppService;
        private readonly IRepository<AppUser, Guid> _repositoryUser;
        public List<SelectListItem> Distributors { get; set; }
        public List<SelectListItem> Spotters { get; set; }
        protected IdentityUserAppService _identityUserAppService { get; }


        public CreateModalModel(IHelpRequestAppService helpRequestAppService,
            IRepository<AppUser, Guid> repositoryUser,
            IdentityUserAppService identityUserAppService)
        {
            _helpRequestAppService = helpRequestAppService;
            _repositoryUser = repositoryUser;
            _identityUserAppService = identityUserAppService;
        }
        public async Task OnGet()
        {
            HelpRequest = new CreateHelpRequestViewModel();
            var userList = await _repositoryUser.GetListAsync();
            var distributorList = new List<AppUser>();
            var spotterList = new List<AppUser>();
            foreach (var item in userList)
            {
                //düzelt
                var itemRoles = _identityUserAppService.GetRolesAsync(item.Id).GetAwaiter().GetResult().Items;
                var isDistributor = itemRoles.Any(x=> x.Id == new Guid("{ADB55C76-AA76-E8B3-9324-39F8D03A60EC}"));
                var isSpotter = itemRoles.Any(x => x.Id == new Guid("{2C9B0292-1B47-B26C-CF6C-39F8D036B3DE}"));
                if (isDistributor)
                    distributorList.Add(item);
                if (isSpotter)
                    spotterList.Add(item);
            }
            Distributors = distributorList.ToList()
                .Select(x => new SelectListItem(x.Name + " "+ x.Surname, x.Id.ToString()))
                .ToList();
            Spotters = spotterList.ToList()
                .Select(x => new SelectListItem(x.Name + " " + x.Surname, x.Id.ToString()))
                .ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _helpRequestAppService.CreateAsync(ObjectMapper.Map<CreateHelpRequestViewModel,CreateUpdateHelpRequestDto>(HelpRequest));
            return NoContent();
        }

        public class CreateHelpRequestViewModel
        {
            [Required]
            public string Name { get; set; }
            [Required]
            public string Surname { get; set; }
            [Required]
            [Range(10000000000, 99999999999, ErrorMessage = "Please enter your 11-digit ID number")]
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
            [SelectItems(nameof(Distributors))]
            [DisplayName("Daðýtýcý Seçiniz")]
            public Guid DistributorId { get; set; }
            [SelectItems(nameof(Spotters))]
            [DisplayName("Denetleyici Seçiniz")]
            public Guid SpotterId { get; set; }
        }

    }
}
