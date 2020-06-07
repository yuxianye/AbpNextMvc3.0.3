using Solution.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Solution
{
    [DependsOn(
        typeof(SolutionEntityFrameworkCoreTestModule)
        )]
    public class SolutionDomainTestModule : AbpModule
    {

    }
}