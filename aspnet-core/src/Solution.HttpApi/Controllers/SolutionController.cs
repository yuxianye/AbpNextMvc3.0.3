using Solution.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Solution.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SolutionController : AbpController
    {
        protected SolutionController()
        {
            LocalizationResource = typeof(SolutionResource);
        }
    }
}