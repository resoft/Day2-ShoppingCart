using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day2_ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_ShoppingCart.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void ShoppingCart_Of_1_Potter_Book_Should_Be_100()
        {
            var expected = 100;
            var orders = new List<Book>()
            {
                  new Book {Quantity = 1 }
            };

            var shoppingCart = new ShoppingCart();

            var actual = shoppingCart.Checkout(orders);

            Assert.AreEqual(expected, actual);
        }
               
    }


}




