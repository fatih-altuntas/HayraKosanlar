using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace HayraKosanlar
{
    public class HayraKosanlarDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<HelpRequest.HelpRequest, Guid> _helpRequestRepository;

        public HayraKosanlarDataSeederContributor(IRepository<HelpRequest.HelpRequest, Guid> helpRequestsRepository)
        {
            _helpRequestRepository = helpRequestsRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _helpRequestRepository.GetCountAsync() <= 0)
            {
                await _helpRequestRepository.InsertAsync(new HelpRequest.HelpRequest
                {
                    Birthplace = "Bakırköy",
                    ChildrenCount = 0,
                    EducationLevel = "Lise",
                    FatherName = "Haydar",
                    IdentityNumber = "11111111111",
                    Job = "Öğrenci",
                    MaritalStatus = HelpRequest.MaritalStatus.Single,
                    MotherName = "Cemile",
                    Name = "Kenan",
                    PartnerName = "",
                    PhoneNumber = "5356668877",
                    Status = HelpRequest.HelpRequestStatus.NewRequest,
                    Surname = "Evren",
                    TownId = 18,
                    ExtraInformation = "Okul için 200 tl harçlık yollarmısınız"
                });
                await _helpRequestRepository.InsertAsync(new HelpRequest.HelpRequest
                {
                    Birthplace = "Kadıköy",
                    ChildrenCount = 0,
                    EducationLevel = "Üniversite",
                    FatherName = "Kerem",
                    IdentityNumber = "11111111111",
                    Job = "İşsiz",
                    MaritalStatus = HelpRequest.MaritalStatus.Single,
                    MotherName = "Hatice",
                    Name = "İbrahim",
                    PartnerName = "",
                    PhoneNumber = "5356668677",
                    Status = HelpRequest.HelpRequestStatus.NewRequest,
                    Surname = "Aydın",
                    TownId = 18,
                    ExtraInformation = "Temel gıda ihtiyacımı karşılarmısınız"
                });
            }
        }
    }
}
