using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNet.Identity;
using Abp.IdentityFramework;

namespace Expeditio.Web.Controllers
{
    public abstract class ExpeditioControllerBase: AbpController
    {
        protected ExpeditioControllerBase()
        {
            LocalizationSourceName = ExpeditioConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}