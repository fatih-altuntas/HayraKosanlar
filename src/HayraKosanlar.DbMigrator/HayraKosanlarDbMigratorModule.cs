﻿using HayraKosanlar.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace HayraKosanlar.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(HayraKosanlarEntityFrameworkCoreDbMigrationsModule),
        typeof(HayraKosanlarApplicationContractsModule)
        )]
    public class HayraKosanlarDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
