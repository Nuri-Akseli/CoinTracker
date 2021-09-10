using CoinTracker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoinTracker.Core.DataAccess.CoinMarketCap
{
    public class CmcEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : class, IDisposable, IJsonRepository<TEntity>, new()
    {
        
        public List<TEntity> GetList()
        {
            using(var Context=new TContext())
            {
                return Context.GetList();
            }
        }
    }
}
