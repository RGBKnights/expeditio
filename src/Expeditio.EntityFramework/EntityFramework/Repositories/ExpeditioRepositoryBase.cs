using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Expeditio.EntityFramework.Repositories
{
    public abstract class ExpeditioRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ExpeditioDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ExpeditioRepositoryBase(IDbContextProvider<ExpeditioDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ExpeditioRepositoryBase<TEntity> : ExpeditioRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ExpeditioRepositoryBase(IDbContextProvider<ExpeditioDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
