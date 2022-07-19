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

            //ColorPriceList coloritem1 = new ColorPriceList() { Color = Color.BLACK, Price = 1 };
            //ColorPriceList coloritem2 = new ColorPriceList() { Color = Color.BLUE, Price = 2 };
            //ColorPriceList coloritem3 = new ColorPriceList() { Color = Color.GREEN, Price = 3 };
            //ColorPriceList coloritem4 = new ColorPriceList() { Color = Color.GREY, Price = 4 };
            //ColorPriceList coloritem5 = new ColorPriceList() { Color = Color.INDIGO, Price = 5 };
            //ColorPriceList coloritem6 = new ColorPriceList() { Color = Color.PURPLE, Price = 6 };
            //ColorPriceList coloritem7 = new ColorPriceList() { Color = Color.VIOLET, Price = 7 };
            //ColorPriceList coloritem8 = new ColorPriceList() { Color = Color.WHITE, Price = 8 };
            //ColorPriceList coloritem9 = new ColorPriceList() { Color = Color.YELLOW, Price = 9 };

            //context.colorPriceLists.AddOrUpdate(coloritem1, coloritem2, coloritem3, coloritem4, coloritem5, coloritem6, coloritem7, coloritem8, coloritem9);
           

            base.Seed(context);

        }
    }
}
