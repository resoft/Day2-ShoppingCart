using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_ShoppingCart
{
    public class ShoppingCart
    {
        /// <summary>
        /// The discounts
        /// </summary>
        private Dictionary<int, double> _discounts;
        /// <summary>
        /// The orders
        /// </summary>
        private IEnumerable<Book> _orders;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCart"/> class.
        /// </summary>
        /// <param name="orders">The orders.</param>
        public ShoppingCart(IEnumerable<Book> orders)
        {
            this._orders = orders;

            this._discounts = new Dictionary<int, double>() {
                 {1, 1},
                 {2, 0.95},
                 {3, 0.9},
                 {4, 0.80},
                 {5, 0.75}
            };
        }

        /// <summary>
        /// Checkouts the specified orders.
        /// </summary>
        /// <param name="orders">The orders.</param>
        /// <returns></returns>
        public int Checkout()
        {
            int price = 100;
            int maxBookCount = this._orders.Max(x => x.Quantity);
            int totalPrice = 0;
            //int i = 0;
            while (maxBookCount > 0)
            {
                int bookCount = this._orders.Where(x => (x.Quantity) >= maxBookCount).Count();

                var discount = GetDisscount(bookCount);

                totalPrice += Convert.ToInt16((bookCount * price) * discount);

                maxBookCount -= 1;
            }

            return totalPrice;
        }

        /// <summary>
        /// Gets the disscount.
        /// </summary>
        /// <param name="bookCount">The book count.</param>
        /// <returns></returns>
        private double GetDisscount(int bookCount)
        {
            if (bookCount > 5) bookCount = 5;
            var discount = this._discounts[bookCount];

            //int discount;
            //switch (bookCount)
            //{
            //    case 1:
            //        discount = (int)BookDiscount.OneBook;
            //        break;
            //    case 2:
            //        discount = (int)BookDiscount.TowBook;
            //        break;
            //    case 3:
            //        discount = (int)BookDiscount.ThreeBook;
            //        break;
            //    case 4:
            //        discount = (int)BookDiscount.FourBook;
            //        break;
            //    default:
            //        discount = (int)BookDiscount.FiveBook;
            //        break;
            //}

            return discount;
        }
    }


    public class Book
    {
        public string BookName { get; set; }
        public int Quantity { get; set; }

    }

    //public enum BookDiscount
    //{
    //    OneBook = 100,
    //    TwoBook = 95,
    //    ThreeBook = 90,
    //    FourBook = 80,
    //    FiveBook = 75
    //}
}
