using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoooLib
{
    /*
     * This delegate as an interface
     * Demo Library maybe used by 10 or 12 different projects , so if you have to change sometging
     * shit happens
     * What if you decide to make discount based on items in shopping cart and not the dollars?????
     * open closed principle says that we shouldn't be making changes this  class if we can help it
     * Action delegate take a parameter and returns nothing.
     */
    public delegate void MentionDiscount(decimal subtotal);
    public class ShoppingCartModel
    {
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        public decimal GenerateTotal(MentionDiscount mentionDiscount, Func<List<ProductModel>,decimal,decimal> calculateDiscounteedTotal,
            Action<string> tellUserWeAreDiscounting)
        {
            decimal subTotal = Items.Sum(x => x.Price);

            mentionDiscount.Invoke(subTotal);

            tellUserWeAreDiscounting("We are applying your discount.");

            return calculateDiscounteedTotal(Items, subTotal);
            //if (subTotal > 100)
            //{
            //    return subTotal * 0.80M;
            //}
            //else if (subTotal > 50)
            //{
            //    return subTotal * 0.85M;
            //}
            //else if (subTotal > 10)
            //{
            //    return subTotal * 0.90M;
            //}
            //else
            //{
            //    return subTotal;
            //}
        }
    }
}
