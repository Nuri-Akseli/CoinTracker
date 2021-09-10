using CoinTracker.Core.DataAccess;
using CoinTracker.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTracker.DataAccess.Abstract
{
    public interface ICoinDal:IEntityRepository<Coin>
    {

    }
}
