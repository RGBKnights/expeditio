using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Expeditio.MultiTenancy;

namespace Expeditio.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}