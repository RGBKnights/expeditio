using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;

namespace Expeditio.EntityFramework
{
    [DependsOn(
        typeof(ExpeditioCoreModule), 
        typeof(AbpZeroEntityFrameworkModule))]
    public class ExpeditioEntityFrameworkModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ExpeditioDbContext>());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}