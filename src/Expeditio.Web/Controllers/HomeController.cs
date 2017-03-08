using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Expeditio.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ExpeditioControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}