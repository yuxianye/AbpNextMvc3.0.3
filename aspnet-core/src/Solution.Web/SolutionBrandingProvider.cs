using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Solution.Web
{
    [Dependency(ReplaceServices = true)]
    public class SolutionBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Solution";
    }
}
