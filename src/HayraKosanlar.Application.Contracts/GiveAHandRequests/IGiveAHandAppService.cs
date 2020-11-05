using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HayraKosanlar.GiveAHandRequests
{
    public interface IGiveAHandAppService :
        ICrudAppService<
            GiveAHandRequestDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateGiveAHandRequestDto>
    {

    }
}
