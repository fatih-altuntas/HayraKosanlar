using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HayraKosanlar.GiveAHandRequests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HayraKosanlar.Web.Pages.GiveAHandRequest
{
    public class EditModalModel : HayraKosanlarPageModel
    {
        [BindProperty(SupportsGet = true)]
        [HiddenInput]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateGiveAHandRequestDto GiveAHandRequest { get; set; }

        private readonly IGiveAHandRequestAppService _giveAHandRequestAppService;

        public EditModalModel(IGiveAHandRequestAppService giveAHandRequestAppService)
        {
            _giveAHandRequestAppService = giveAHandRequestAppService;
        }
        public async Task OnGetAsync()
        {
            var giveAHandRequestDto = await _giveAHandRequestAppService.GetAsync(Id);
            GiveAHandRequest = ObjectMapper.Map<GiveAHandRequestDto, CreateUpdateGiveAHandRequestDto>(giveAHandRequestDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _giveAHandRequestAppService.UpdateAsync(Id, GiveAHandRequest);
            return NoContent();
        }
    }
}
