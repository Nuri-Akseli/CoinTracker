using CoinTracker.Business.Abstract;
using CoinTracker.Business.Concrete.Managers;
using CoinTracker.DataAccess.Abstract;
using CoinTracker.DataAccess.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTracker.Business.DependancyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICoinService>().To<CoinManager>().InSingletonScope();
            Bind<ICoinDal>().To<CoinDal>().InSingletonScope();
        }
    }
}
