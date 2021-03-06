using CoinTracker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoinTracker.Core.DataAccess
{
    public interface IJsonRepository<T> where T: class, IEntity,new()
    {
        List<T> GetList();
    }
}
