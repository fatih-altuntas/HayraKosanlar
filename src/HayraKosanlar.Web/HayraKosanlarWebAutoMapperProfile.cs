using AutoMapper;
using HayraKosanlar.HelpRequests;

namespace HayraKosanlar.Web
{
    public class HayraKosanlarWebAutoMapperProfile : Profile
    {
        public HayraKosanlarWebAutoMapperProfile()
        {
            CreateMap<HelpRequestDto,CreateUpdateHelpRequestDto>();
            //Define your AutoMapper configuration here for the Web project.
        }
    }
}
