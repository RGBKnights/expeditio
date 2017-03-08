using Abp.Authorization;
using Expeditio.Authorization.Roles;
using Expeditio.MultiTenancy;
using Expeditio.Users;

namespace Expeditio.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
