using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HayraKosanlar.Data
{
    /* This is used if database provider does't define
     * IHayraKosanlarDbSchemaMigrator implementation.
     */
    public class NullHayraKosanlarDbSchemaMigrator : IHayraKosanlarDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}