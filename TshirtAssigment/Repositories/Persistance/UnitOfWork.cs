using MyDatabase;
using Repositories.Core;
using Repositories.Core.Repositories;
using Repositories.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyApplicationContext db;

        public UnitOfWork(MyApplicationContext context)
        {
            db = context;
            Tshirt = new TshirtRepository(context);
            FabricPriceList = new FabricPriceListRepository(context);
            SizePriceList = new SizePriceListRepository(context);
            ColorPriceList = new ColorPriceListRepository(context);
        }
        public IFabricPriceListRepository FabricPriceList { get; private set; }

        public ITshirtRepository Tshirt { get; private set; }

        public ISizePriceListRepository SizePriceList { get; private set; }

        public IColorPriceListRepository ColorPriceList { get; private set; }


        

        public int complete()
        {
            return db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
