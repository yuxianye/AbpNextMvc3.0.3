using System;
using System.Collections.Generic;
using System.Text;
using Solution.Localization;
using Volo.Abp.Application.Services;

namespace Solution
{
    /* Inherit your application services from this class.
     */
    public abstract class SolutionAppService : ApplicationService
    {
        protected SolutionAppService()
        {
            LocalizationResource = typeof(SolutionResource);
        }
    }
}
