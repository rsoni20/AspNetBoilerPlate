using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ME.Controllers
{
    public abstract class MEControllerBase: AbpController
    {
        protected MEControllerBase()
        {
            LocalizationSourceName = MEConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}