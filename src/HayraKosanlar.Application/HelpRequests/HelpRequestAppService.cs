using System;
using HayraKosanlar.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HayraKosanlar.HelpRequests
{
    public class HelpRequestAppService :
        CrudAppService< //Defines CRUD methods
            HelpRequest, //The HelpRequestEntity
            HelpRequestDto, //Used to show help requests,
            Guid, //Primary key of the 
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateHelpRequestDto>, // Used to create/update a book
        IHelpRequestAppService
    {
        public HelpRequestAppService(IRepository<HelpRequest,Guid> repository) : base(repository)
        {
            GetPolicyName = HayraKosanlarPermissions.HelpRequest.List;
            GetListPolicyName = HayraKosanlarPermissions.HelpRequest.List;
            CreatePolicyName = HayraKosanlarPermissions.HelpRequest.Create;
            UpdatePolicyName = HayraKosanlarPermissions.HelpRequest.Edit;
        }
    }
}
