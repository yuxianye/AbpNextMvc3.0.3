using Volo.Abp.Modularity;

namespace Solution
{
    [DependsOn(
        typeof(SolutionApplicationModule),
        typeof(SolutionDomainTestModule)
        )]
    public class SolutionApplicationTestModule : AbpModule
    {

    }
}