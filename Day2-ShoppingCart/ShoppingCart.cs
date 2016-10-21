using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_ShoppingCart
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {

        }

        public object Checkout(List<Book> orders)
        {
            throw new NotImplementedException();
        }
    }

    public class Book
    {
        public int Quantity { get; set; }
   
    }
}
