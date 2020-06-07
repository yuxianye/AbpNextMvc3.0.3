using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Solution.EntityFrameworkCore
{
    [DependsOn(
        typeof(SolutionEntityFrameworkCoreModule)
        )]
    public class SolutionEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SolutionMigrationsDbContext>();
        }
    }
}
