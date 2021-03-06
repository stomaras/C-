using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IFabricPriceListRepository FabricPriceList { get; }

        ITshirtRepository Tshirt { get; }

        ISizePriceListRepository SizePriceList { get; }

        IColorPriceListRepository ColorPriceList { get; }

        int complete();
    }
}
