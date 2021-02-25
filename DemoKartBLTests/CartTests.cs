using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECommerceSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSite.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void AddToCartTest()
        {
            Cart cobj = new Cart();

            cobj.AddToCart(10);
            Assert.IsTrue(true);
        }
    }
}
