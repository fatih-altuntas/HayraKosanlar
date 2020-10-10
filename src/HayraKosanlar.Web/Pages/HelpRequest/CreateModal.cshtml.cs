using HayraKosanlar.HelpRequest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace HayraKosanlar.Web.Pages.HelpRequest
{
    public class CreateModalModel : HayraKosanlarPageModel
    {
        [BindProperty]
        public CreateUpdateHelpRequestDto HelpRequest { get; set; }
        private readonly IHelpRequestAppService _helpRequestAppService;

        public CreateModalModel(IHelpRequestAppService helpRequestAppService)
        {
            _helpRequestAppService = helpRequestAppService;
        }
        public void OnGet()
        {
            HelpRequest = new CreateUpdateHelpRequestDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _helpRequestAppService.CreateAsync(HelpRequest);
            return NoContent();
        }
    }
}
