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
            int price = 100;
            int bookCount = orders.Count();
            int discount=100;
            switch (bookCount)
            {
                case 1:
                    discount = (int)BookDiscount.OneBook;
                    break;
                case 2:
                    discount = (int)BookDiscount.TowBook;
                    break;
                case 3:
                    discount = (int)BookDiscount.ThreeBook;
                    break;
                case 4:
                    discount = (int)BookDiscount.FourBook;
                    break;
                default:
                    break;
            }
        
            int totalPrice = ((bookCount * price) / 100) * discount;
            return totalPrice;
        }
    }

    public class Book
    {
        public string BookName { get; set; }
        public int Quantity { get; set; }

    }

    public enum BookDiscount
    {
        OneBook = 100,
        TowBook = 95,
        ThreeBook = 90,
        FourBook = 80
    }
}
