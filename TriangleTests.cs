using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        private Triangle triangle;

        [TestInitialize()]
        public void Initialize()
        {
            triangle = new Triangle();
        }

        [TestMethod()]
        public void AreaTest_9()
        {
            triangle.Catheter1 = 3;
            triangle.Catheter2 = 6;
            Assert.AreEqual(9, triangle.Area());
        }

        [TestMethod()]
        public void AreaTest_12andHalf()
        {
            triangle.Catheter1 = 5;
            triangle.Catheter2 = 5;
            Assert.AreEqual(12.5, triangle.Area());
        }

        [TestMethod()]
        public void AreaTestNegEntry_0()
        {
            triangle.Catheter1 = -2;
            triangle.Catheter2 = -1;
            Assert.AreEqual(0, triangle.Area());
        }
    }
}