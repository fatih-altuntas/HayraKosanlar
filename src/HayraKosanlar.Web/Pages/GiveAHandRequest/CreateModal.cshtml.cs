using HayraKosanlar.GiveAHandRequests;
using HayraKosanlar.HelpRequests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HayraKosanlar.Web.Pages.GiveAHandRequest
{
    public class CreateModalModel : HayraKosanlarPageModel
    {
        [BindProperty]
        public CreateUpdateGiveAHandRequestDto GiveAHandRequest { get; set; }
        private readonly IGiveAHandRequestAppService _giveAHandRequestAppService;

        public CreateModalModel(IGiveAHandRequestAppService giveAHandRequestAppService)
        {
            _giveAHandRequestAppService = giveAHandRequestAppService;
        }
        public void OnGet()
        {
            GiveAHandRequest = new CreateUpdateGiveAHandRequestDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _giveAHandRequestAppService.CreateAsync(GiveAHandRequest);
            return NoContent();
        }
    }
}
