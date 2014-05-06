using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EStore;

namespace Test
{
    [TestClass]
    public class TestDiscount
    {
        [TestMethod]
        public void AssertSumIsZero()
        {
            var cart = new ShoppingCart();
            Assert.AreEqual((double)0, cart.Sum(), "Should be zero");
        }
    }
}
