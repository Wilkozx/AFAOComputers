using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class TstProduct
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);
        }
    }
}
