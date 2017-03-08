using Abp.AspNetCore.Mvc.Authorization;
using Expeditio.Authorization;
using Expeditio.MultiTenancy;
using Microsoft.AspNetCore.Mvc;

namespace Expeditio.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : ExpeditioControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}