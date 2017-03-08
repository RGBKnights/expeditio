using System.Threading.Tasks;
using Abp.Application.Services;
using Expeditio.Roles.Dto;

namespace Expeditio.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
