using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Addition.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        [TestMethod()]
        public void SumTest()
        {
            var c = AdditionTime.Sum(1, 2);
            Assert.AreEqual(3, c);
        }
    }
}
