using Microsoft.AspNetCore.Mvc;

namespace Expeditio.Web.Controllers
{
    public class AboutController : ExpeditioControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}