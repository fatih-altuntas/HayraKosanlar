using HayraKosanlar.GiveAHandRequests;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace HayraKosanlar
{
    public class HayraKosanlarDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<HelpRequests.HelpRequest, Guid> _helpRequestRepository;
        private readonly IRepository<GiveAHandRequest, Guid> _giveAHandRequestRepository;

        public HayraKosanlarDataSeederContributor(
            IRepository<HelpRequests.HelpRequest, Guid> helpRequestsRepository,
            IRepository<GiveAHandRequest, Guid> giveAHandRequestRepository
            )
        {
            _helpRequestRepository = helpRequestsRepository;
            _giveAHandRequestRepository = giveAHandRequestRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _helpRequestRepository.GetCountAsync() <= 0)
            {
                await _helpRequestRepository.InsertAsync(new HelpRequests.HelpRequest
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
                    ExtraInformation = "Okul için 200 tl harçlık yollarmısınız"
                });
                await _helpRequestRepository.InsertAsync(new HelpRequests.HelpRequest
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
                    ExtraInformation = "Temel gıda ihtiyacımı karşılarmısınız"
                });
            }

            if (await _giveAHandRequestRepository.GetCountAsync() <= 0)
            {
                await _giveAHandRequestRepository.InsertAsync(new GiveAHandRequest
                {
                    Name = "Yardım",
                    Surname = "Sever",
                    PhoneNumber = "5356661122"
                });
            }
        }
    }
}
