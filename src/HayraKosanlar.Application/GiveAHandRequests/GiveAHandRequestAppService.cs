using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HayraKosanlar.GiveAHandRequests
{
    public class GiveAHandRequestAppService :
       CrudAppService<
           GiveAHandRequest, //The Book entity
           GiveAHandRequestDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateGiveAHandRequestDto>, //Used to create/update a book
       IGiveAHandRequestAppService //implement the IBookAppService
    {
        public GiveAHandRequestAppService(IRepository<GiveAHandRequest, Guid> repository)
            : base(repository)
        {

        }
    }
}
