using System.Threading.Tasks;
using Abp.Application.Services;
using Expeditio.Sessions.Dto;

namespace Expeditio.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
