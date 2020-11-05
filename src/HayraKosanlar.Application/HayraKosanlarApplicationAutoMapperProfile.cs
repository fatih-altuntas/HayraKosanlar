using AutoMapper;
using HayraKosanlar.GiveAHandRequests;
using HayraKosanlar.HelpRequests;

namespace HayraKosanlar
{
    public class HayraKosanlarApplicationAutoMapperProfile : Profile
    {
        public HayraKosanlarApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<HelpRequests.HelpRequest, HelpRequestDto>();
            CreateMap<CreateUpdateHelpRequestDto, HelpRequests.HelpRequest>();
            CreateMap<GiveAHandRequest, GiveAHandRequestDto>();
            CreateMap<CreateUpdateGiveAHandRequestDto, GiveAHandRequest>();
        }
    }
}
