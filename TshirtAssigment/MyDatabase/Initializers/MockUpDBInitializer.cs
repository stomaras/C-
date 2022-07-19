using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.Migrations;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Initializers
{
    public class MockUpDBInitializer : DropCreateDatabaseAlways<MyApplicationContext>
    {

        protected override void Seed(MyApplicationContext context)
        {
            Tshirt t1 = new Tshirt() { Color = Color.BLACK, Fabric = Fabric.COTTON, Size = Size.S, Mark = Mark.Adidas};
            Tshirt t2 = new Tshirt() { Color = Color.VIOLET, Fabric = Fabric.LINEN, Size = Size.M, Mark = Mark.Nike};
            Tshirt t3 = new Tshirt() { Color = Color.PURPLE, Fabric = Fabric.RAYON, Size = Size.XL, Mark = Mark.Armani};
            Tshirt t4 = new Tshirt() { Color = Color.YELLOW, Fabric = Fabric.CASHMERE, Size = Size.XXL, Mark = Mark.Vans};
            Tshirt t5 = new Tshirt() { Color = Color.INDIGO, Fabric = Fabric.SILK, Size = Size.XXXL, Mark = Mark.Adidas};

            context.Tshirts.AddOrUpdate(t1, t2, t3, t4, t5);

            ColorPriceList coloritem1 = new ColorPriceList() { Color = Color.BLACK, Price = 1 };
            ColorPriceList coloritem2 = new ColorPriceList() { Color = Color.BLUE, Price = 2 };
            ColorPriceList coloritem3 = new ColorPriceList() { Color = Color.GREEN, Price = 3 };
            ColorPriceList coloritem4 = new ColorPriceList() { Color = Color.GREY, Price = 4 };
            ColorPriceList coloritem5 = new ColorPriceList() { Color = Color.INDIGO, Price = 5 };
            ColorPriceList coloritem6 = new ColorPriceList() { Color = Color.PURPLE, Price = 6 };
            ColorPriceList coloritem7 = new ColorPriceList() { Color = Color.VIOLET, Price = 7 };
            ColorPriceList coloritem8 = new ColorPriceList() { Color = Color.WHITE, Price = 8 };
            ColorPriceList coloritem9 = new ColorPriceList() { Color = Color.YELLOW, Price = 9 };

            context.colorPriceLists.AddOrUpdate(coloritem1, coloritem2, coloritem3, coloritem4, coloritem5, coloritem6, coloritem7, coloritem8, coloritem9);

            SizePriceList sizeitem1 = new SizePriceList() { Size = Size.S, Price = 2 };
            SizePriceList sizeitem2 = new SizePriceList() { Size = Size.XS, Price = 1 };
            SizePriceList sizeitem3 = new SizePriceList() { Size = Size.M, Price = 3 };
            SizePriceList sizeitem4 = new SizePriceList() { Size = Size.L, Price = 5 };
            SizePriceList sizeitem5 = new SizePriceList() { Size = Size.XL, Price = 7 };
            SizePriceList sizeitem6 = new SizePriceList() { Size = Size.XXL, Price = 10 };
            SizePriceList sizeitem7 = new SizePriceList() { Size = Size.XXXL, Price = 14 };

            context.sizePriceLists.AddOrUpdate(sizeitem1, sizeitem2, sizeitem3, sizeitem4, sizeitem5, sizeitem6, sizeitem7);

            FabricPriceList fabricitem1 = new FabricPriceList() { Fabric = Fabric.CASHMERE, Price = 100 };
            FabricPriceList fabricitem2 = new FabricPriceList() { Fabric = Fabric.COTTON, Price = 10 };
            FabricPriceList fabricitem3 = new FabricPriceList() { Fabric = Fabric.LINEN, Price = 15 };
            FabricPriceList fabricitem4 = new FabricPriceList() { Fabric = Fabric.POLYESTER, Price = 45 };
            FabricPriceList fabricitem5 = new FabricPriceList() { Fabric = Fabric.SILK, Price = 30 };
            FabricPriceList fabricitem6 = new FabricPriceList() { Fabric = Fabric.WOOL, Price = 50 };
            FabricPriceList fabricitem7 = new FabricPriceList() { Fabric = Fabric.RAYON, Price = 25 };

            context.fabricPriceLists.AddOrUpdate(fabricitem1, fabricitem2, fabricitem3, fabricitem4, fabricitem5, fabricitem6, fabricitem7);



            base.Seed(context);

        }
    }
}
