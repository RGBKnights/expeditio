using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using Expeditio.Configuration;
using Expeditio.EntityFramework;

namespace Expeditio.Migrator
{
    [DependsOn(typeof(ExpeditioEntityFrameworkModule))]
    public class ExpeditioMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ExpeditioMigratorModule()
        {
            _appConfiguration = AppConfigurations.Get(
                typeof(ExpeditioMigratorModule).Assembly.GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Database.SetInitializer<ExpeditioDbContext>(null);

            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ExpeditioConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}