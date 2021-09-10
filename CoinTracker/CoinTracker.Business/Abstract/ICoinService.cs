using CoinTracker.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTracker.Business.Abstract
{
    public interface ICoinService
    {
        List<Coin> GetList(string name=null);
    }
}
