using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HayraKosanlar.HelpRequest;
using HayraKosanlar.Permissions;
using HayraKosanlar.Users;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Data;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Users;

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
        private readonly ICurrentUser _currentUser;
        private readonly IRepository<AppUser, Guid> _repositoryUser;
        public HelpRequestAppService(IRepository<HelpRequest,Guid> repository, ICurrentUser currentUser, IRepository<AppUser, Guid> repositoryUser) : base(repository)
        {
            GetPolicyName = HayraKosanlarPermissions.HelpRequest.List;
            GetListPolicyName = HayraKosanlarPermissions.HelpRequest.List;
            CreatePolicyName = HayraKosanlarPermissions.HelpRequest.Create;
            UpdatePolicyName = HayraKosanlarPermissions.HelpRequest.Edit;
            _currentUser = currentUser;
            _repositoryUser = repositoryUser;
        }

        public async Task<PagedResultDto<HelpRequestDto>> ListByStatus(long status=1)
        {
            var HelpRequestList = await GetListAsync(new PagedAndSortedResultRequestDto());
            HelpRequestList.Items =  HelpRequestList.Items.Where(x => x.Status == (HelpRequestStatus)status).OrderByDescending(x=> x.CreationTime).ToList();
            HelpRequestList.TotalCount = HelpRequestList.Items.Count;
            return HelpRequestList;
        }
        public async Task<ListResultDto<DistributorLookupDto>> GetDistributorLookupAsync()
        {
            var distributors = await _repositoryUser.GetListAsync();
            return new ListResultDto<DistributorLookupDto>(
                ObjectMapper.Map<List<AppUser>, List<DistributorLookupDto>>(distributors)
            );
        }
    }
}
