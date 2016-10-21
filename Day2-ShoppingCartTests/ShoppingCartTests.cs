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

            var actual = orders.Checkout();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void ShoppingCart_Of_2_Potter_Book_Should_Be_190()
        {
            var expected = 190;
            var orders = new List<Book>()
            {
                  new Book { BookName = "Potter_1", Quantity = 1 },
                  new Book {BookName = "Potter_2", Quantity = 1 }
            };

            var actual = orders.Checkout();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShoppingCart_Of_3_Potter_Book_Should_Be_270()
        {
            var expected = 270;
            var orders = new List<Book>()
            {
                  new Book { BookName = "Potter_1", Quantity = 1 },
                  new Book {BookName = "Potter_2", Quantity = 1 },
                  new Book {BookName = "Potter_3", Quantity = 1 }
            };

            var actual = orders.Checkout();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShoppingCart_Of_4_Potter_Book_Should_Be_320()
        {
            var expected = 320;
            var orders = new List<Book>()
            {
                  new Book { BookName = "Potter_1", Quantity = 1 },
                  new Book {BookName = "Potter_2", Quantity = 1 },
                  new Book {BookName = "Potter_3", Quantity = 1 },
                  new Book {BookName = "Potter_4", Quantity = 1 }
            };

            var actual = orders.Checkout();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShoppingCart_Of_5_Potter_Book_Should_Be_375()
        {
            var expected = 375;
            var orders = new List<Book>()
            {
                  new Book { BookName = "Potter_1", Quantity = 1 },
                  new Book {BookName = "Potter_2", Quantity = 1 },
                  new Book {BookName = "Potter_3", Quantity = 1 },
                  new Book {BookName = "Potter_4", Quantity = 1 },
                  new Book {BookName = "Potter_5", Quantity = 1 }
            };

            var actual = orders.Checkout();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShoppingCart_Of_Potter_1_Buy_Book_1_Potter_2_Buy_Book_1_Potter_3_Buy_Book_2_Should_Be_370()
        {
            var expected = 370;
            var orders = new List<Book>()
            {
                  new Book { BookName = "Potter_1", Quantity = 1 },
                  new Book {BookName = "Potter_2", Quantity = 1 },
                  new Book {BookName = "Potter_3", Quantity = 2 },
            };


            var actual = orders.Checkout();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShoppingCart_Of_Potter_1_Buy_Book_1_Potter_2_Buy_Book_2_Potter_3_Buy_Book_2_Should_Be_460()
        {
            var expected = 460;
            var orders = new List<Book>()
            {
                  new Book { BookName = "Potter_1", Quantity = 1 },
                  new Book {BookName = "Potter_2", Quantity = 2 },
                  new Book {BookName = "Potter_3", Quantity = 2 }
            };

            var actual = orders.Checkout();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void ShoppingCart_Of_Potter_1_Buy_Book_1_Potter_2_Buy_Book_2_Potter_3_Buy_Book_2_Potter_4_Buy_Book_5_Should_Be_890()
        {
            var expected = 890;
            var orders = new List<Book>()
            {
                  new Book { BookName = "Potter_1", Quantity = 1 },
                  new Book {BookName = "Potter_2", Quantity = 2 },
                  new Book {BookName = "Potter_3", Quantity = 2 },
                  new Book {BookName = "Potter_4", Quantity = 5 }
            };

            var actual = orders.Checkout();

            Assert.AreEqual(expected, actual);
        }
    }


}




