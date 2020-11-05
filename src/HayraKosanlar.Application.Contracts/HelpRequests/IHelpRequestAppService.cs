using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HayraKosanlar.HelpRequests
{
    public interface IHelpRequestAppService : 
        ICrudAppService< //Defines CRUD methods
            HelpRequestDto, //Used to show help requests,
            Guid, //Primary key of the 
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateHelpRequestDto> // Used to create/update a book
    {

    }
}
