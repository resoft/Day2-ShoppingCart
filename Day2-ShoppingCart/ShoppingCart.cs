using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_ShoppingCart
{
    public static class ShoppingCart
    {
        /// <summary>
        /// Checkouts the specified orders.
        /// </summary>
        /// <param name="orders">The orders.</param>
        /// <returns></returns>
        public static int Checkout(this IEnumerable<Book> orders)
        {
            int price = 100;
            int maxBookCount = orders.Max(x => x.Quantity);
            int totalPrice = 0;
            int i = 0;
            while (maxBookCount > 0)
            {
                int bookCount = orders.Where(x => (x.Quantity - i) >= maxBookCount).Count();

                int discount = GetDisscount(bookCount);

                totalPrice += ((bookCount * price) / 100) * discount;

                maxBookCount = maxBookCount - 1;
            }

            return totalPrice;
        }

        /// <summary>
        /// Gets the disscount.
        /// </summary>
        /// <param name="bookCount">The book count.</param>
        /// <returns></returns>
        private static int GetDisscount(int bookCount)
        {
            int discount;
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
                    discount = (int)BookDiscount.FiveBook;
                    break;
            }

            return discount;
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
        FourBook = 80,
        FiveBook = 75
    }
}
