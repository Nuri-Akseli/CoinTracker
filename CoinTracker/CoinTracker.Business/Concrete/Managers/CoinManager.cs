using CoinTracker.Business.Abstract;
using CoinTracker.DataAccess.Abstract;
using CoinTracker.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTracker.Business.Concrete.Managers
{
    public class CoinManager : ICoinService
    {
        private ICoinDal _coinDal;
        public CoinManager(ICoinDal coinDal)
        {
            _coinDal = coinDal;
        }
        public List<Coin> GetList(string name = null)
        {
            return name == null
                ? _coinDal.GetList()
                : _coinDal.GetList().Where(x=>x.name.ToLower().Trim().Contains(name.ToLower().Trim())).ToList();
               
        }
    }
}
