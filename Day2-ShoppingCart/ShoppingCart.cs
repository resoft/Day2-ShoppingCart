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

        public int Checkout(List<Book> orders)
        {
            return 100;
        }
    }

    public class Book
    {
        public string BookName { get; set; }
        public int Quantity { get; set; }
   
    }
}
