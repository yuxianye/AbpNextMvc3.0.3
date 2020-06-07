using Solution.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Solution.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SolutionEntityFrameworkCoreDbMigrationsModule),
        typeof(SolutionApplicationContractsModule)
        )]
    public class SolutionDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
