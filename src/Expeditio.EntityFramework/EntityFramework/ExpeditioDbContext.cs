using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Microsoft.Extensions.Configuration;
using Expeditio.Authorization.Roles;
using Expeditio.Configuration;
using Expeditio.MultiTenancy;
using Expeditio.Users;
using Expeditio.Web;

namespace Expeditio.EntityFramework
{
    [DbConfigurationType(typeof(ExpeditioDbConfiguration))]
    public class ExpeditioDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        /* Default constructor is needed for EF command line tool. */
        public ExpeditioDbContext()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder()
                );

            return configuration.GetConnectionString(
                ExpeditioConsts.ConnectionStringName
                );
        }

        /* This constructor is used by ABP to pass connection string.
         * Notice that, actually you will not directly create an instance of ExpeditioDbContext since ABP automatically handles it.
         */
        public ExpeditioDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection. */
        public ExpeditioDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }

        public ExpeditioDbContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {

        }
    }

    public class ExpeditioDbConfiguration : DbConfiguration
    {
        public ExpeditioDbConfiguration()
        {
            SetProviderServices(
                "System.Data.SqlClient",
                System.Data.Entity.SqlServer.SqlProviderServices.Instance
            );
        }
    }
}
