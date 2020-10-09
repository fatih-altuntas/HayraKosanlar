using System.Threading.Tasks;

namespace HayraKosanlar.Data
{
    public interface IHayraKosanlarDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
