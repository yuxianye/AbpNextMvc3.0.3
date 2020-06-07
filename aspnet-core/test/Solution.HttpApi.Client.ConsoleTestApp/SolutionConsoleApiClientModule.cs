using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Solution.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(SolutionHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class SolutionConsoleApiClientModule : AbpModule
    {
        
    }
}
