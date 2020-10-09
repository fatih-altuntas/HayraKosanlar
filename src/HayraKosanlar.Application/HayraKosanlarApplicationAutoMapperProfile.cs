using AutoMapper;
using HayraKosanlar.HelpRequest;

namespace HayraKosanlar
{
    public class HayraKosanlarApplicationAutoMapperProfile : Profile
    {
        public HayraKosanlarApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<HelpRequest.HelpRequest, HelpRequestDto>();
            CreateMap<CreateUpdateHelpRequestDto, HelpRequest.HelpRequest>();
        }
    }
}
