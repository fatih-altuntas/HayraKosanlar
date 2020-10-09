using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace HayraKosanlar.EntityFrameworkCore
{
    public static class HayraKosanlarDbContextModelCreatingExtensions
    {
        public static void ConfigureHayraKosanlar(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<HelpRequest.HelpRequest>(b =>
            {
                b.ToTable("HelpRequest", HayraKosanlarConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x=> x.Name).IsRequired().HasMaxLength(128);
            });
            //builder.Entity<HelpRequest.HelpRequest>(b =>
            //{
            //    b.ToTable(HayraKosanlarConsts.DbTablePrefix + "HelpRequest", HayraKosanlarConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            //});
        }
    }
}