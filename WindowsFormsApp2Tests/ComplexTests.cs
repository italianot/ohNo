using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Tests
{
    [TestClass()]
    public class ComplexTests
    {
        [TestMethod()]
        public void VerboseTest()
        {
            var complex = new Complex(10);
            Assert.AreEqual("10", complex.Verbose());
        }

        [TestMethod()]
        public void AddNumberTest()
        {
            var complex = new Complex(1);
            complex = complex + 4.25;
            Assert.AreEqual("5,25", complex.Verbose());
        }

        [TestMethod()]
        public void SubNumberTest()
        {
            var complex = new Complex(3);
            complex = complex - 1.75;
            Assert.AreEqual("1,25", complex.Verbose());
        }

        [TestMethod()]
        public void MulByNumberTest()
        {
            var complex = new Complex(3);
            complex = complex * 3;
            Assert.AreEqual("9", complex.Verbose());
        }

        [TestMethod()]
        public void DivByNumberTest()
        {
            var complex = new Complex(3);
            complex = complex / 3;
            Assert.AreEqual("1", complex.Verbose());
        }
    }
}