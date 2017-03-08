using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Expeditio.Authorization;
using Expeditio.Users;
using Microsoft.AspNetCore.Mvc;

namespace Expeditio.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : ExpeditioControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}