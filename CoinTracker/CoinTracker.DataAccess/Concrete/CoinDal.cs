using CoinTracker.Core.DataAccess.CoinMarketCap;
using CoinTracker.DataAccess.Abstract;
using CoinTracker.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTracker.DataAccess.Concrete
{
    public class CoinDal : CmcEntityRepositoryBase<Coin, CoinMarketCapContext>, ICoinDal
    {
     
    }
}
