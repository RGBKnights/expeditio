using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Expeditio.MultiTenancy.Dto;

namespace Expeditio.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
