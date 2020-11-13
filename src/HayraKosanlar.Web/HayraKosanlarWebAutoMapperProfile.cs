using AutoMapper;
using HayraKosanlar.HelpRequests;

namespace HayraKosanlar.Web
{
    public class HayraKosanlarWebAutoMapperProfile : Profile
    {
        public HayraKosanlarWebAutoMapperProfile()
        {
            CreateMap<HelpRequestDto,CreateUpdateHelpRequestDto>();
            CreateMap<Pages.HelpRequest.CreateModalModel.CreateHelpRequestViewModel, CreateUpdateHelpRequestDto>();
            CreateMap<HelpRequestDto, Pages.HelpRequest.EditModalModel.EditHelpRequestViewModel>();
            CreateMap<Pages.HelpRequest.EditModalModel.EditHelpRequestViewModel, CreateUpdateHelpRequestDto>();
            //Define your AutoMapper configuration here for the Web project.
        }
    }
}
