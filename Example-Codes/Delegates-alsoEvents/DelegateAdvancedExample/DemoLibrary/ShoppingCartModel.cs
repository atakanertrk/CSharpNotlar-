using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        // definition of delegate (signature), you can think it like interface/promise
        // Paramater "subTotal" name is not important. You can name it something else either.
        public delegate void MentionDiscount(decimal subTotal);
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        // ""Func<> method"" takes "List<ProductModel>" and one "decimal" value as input,
        // last one "decimal" is output.
        // With using Func<> we dont need to use signature like we did for MentionDiscount
        public decimal GenerateTotal(MentionDiscount mentionSubtotal,
            Func<List<ProductModel>,decimal,decimal> calculateDiscountedTotal,
            Action<string> tellUserWeAreDiscounting)
        {
            decimal subTotal = Items.Sum(x => x.Price);

            mentionSubtotal(subTotal);

            tellUserWeAreDiscounting("applying discount...");

            // Only send two paramater. last paramater of calculateDiscountedTotal 
            // is output(decimal)
            decimal total =  calculateDiscountedTotal(Items,subTotal);
            return total;
            // Func is a delegate that points to a method that accepts one or more 
            // arguments and returns a value. Action is a delegate that points to a method
            // which in turn accepts one or more arguments but returns no value. In other words, 
            // you should use Action when your delegate points to a method that returns void.

        }
    }
}
