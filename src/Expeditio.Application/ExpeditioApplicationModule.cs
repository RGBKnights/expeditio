using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Expeditio.Authorization;

namespace Expeditio
{
    [DependsOn(
        typeof(ExpeditioCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ExpeditioApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ExpeditioAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}