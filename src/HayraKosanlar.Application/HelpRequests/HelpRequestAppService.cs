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
using Volo.Abp.Identity;
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
        protected IdentityUserAppService _identityUserAppService { get; }
        public HelpRequestAppService(IRepository<HelpRequest,Guid> repository,
            ICurrentUser currentUser,
            IRepository<AppUser, Guid> repositoryUser,
            IdentityUserAppService identityUserAppService) : base(repository)
        {
            GetPolicyName = HayraKosanlarPermissions.HelpRequest.List;
            GetListPolicyName = HayraKosanlarPermissions.HelpRequest.List;
            UpdatePolicyName = HayraKosanlarPermissions.HelpRequest.Edit;
            _currentUser = currentUser;
            _repositoryUser = repositoryUser;
            _identityUserAppService = identityUserAppService;
        }

        public async Task<PagedResultDto<HelpRequestDto>> ListByStatus(long status=1)
        {
            var HelpRequestList = await GetListAsync(new PagedAndSortedResultRequestDto());
            if (_currentUser.Roles.Any(x => x.Contains("admin")))
                HelpRequestList.Items = HelpRequestList.Items.Where(x => x.Status == (HelpRequestStatus)status).OrderByDescending(x => x.CreationTime).ToList();
            else if (_currentUser.Roles.Any(x => x.Contains("spotter")))
                HelpRequestList.Items = HelpRequestList.Items.Where(x => x.Status == HelpRequestStatus.WaitingForDetection && x.SpotterId == (Guid)_currentUser.Id).OrderByDescending(x => x.CreationTime).ToList();
            else if (_currentUser.Roles.Any(x => x.Contains("distributor")))
                HelpRequestList.Items = HelpRequestList.Items.Where(x => x.Status == HelpRequestStatus.DeliveryWaiting).OrderByDescending(x => x.CreationTime).ToList();
            else
                HelpRequestList = new PagedResultDto<HelpRequestDto>();
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
