using HayraKosanlar.HelpRequests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HayraKosanlar.Web.Pages.HelpRequest
{
    public class EditModalModel : HayraKosanlarPageModel
    {
        [BindProperty(SupportsGet = true)]
        [HiddenInput]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateHelpRequestDto HelpRequest { get; set; }

        private readonly IHelpRequestAppService _helpRequestAppService;

        public EditModalModel(IHelpRequestAppService helpRequestAppService)
        {
            _helpRequestAppService = helpRequestAppService;
        }
        public async Task OnGetAsync()
        {
            var helpRequestDto = await _helpRequestAppService.GetAsync(Id);
            HelpRequest = ObjectMapper.Map<HelpRequestDto, CreateUpdateHelpRequestDto>(helpRequestDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _helpRequestAppService.UpdateAsync(Id, HelpRequest);
            return NoContent();
        }
    }
}
