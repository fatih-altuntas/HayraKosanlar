using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace HayraKosanlar.EntityFrameworkCore
{
    public static class HayraKosanlarDbContextModelCreatingExtensions
    {
        public static void ConfigureHayraKosanlar(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(HayraKosanlarConsts.DbTablePrefix + "YourEntities", HayraKosanlarConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}