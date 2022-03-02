using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void CharToIntTest()
        {
            int testI = RomanNumber.CharToInt('I');
            int expectI = 1;
            Assert.AreEqual(expectI, testI);

            int testV = RomanNumber.CharToInt('V');
            int expectV = 5;
            Assert.AreEqual(expectV, testV);

            int testX = RomanNumber.CharToInt('X');
            int expectX = 10;
            Assert.AreEqual(expectX, testX);

            int testL = RomanNumber.CharToInt('L');
            int expectL = 50;
            Assert.AreEqual(expectL, testL);

            int testC = RomanNumber.CharToInt('C');
            int expectC = 100;
            Assert.AreEqual(expectC, testC);

            int testD = RomanNumber.CharToInt('D');
            int expectD = 500;
            Assert.AreEqual(expectD, testD);

            int testM = RomanNumber.CharToInt('M');
            int expectM = 1000;
            Assert.AreEqual(expectM, testM);

            int testOther = RomanNumber.CharToInt('R');
            int expectOther = 0;
            Assert.AreEqual(expectOther, testOther);
        }

        [TestMethod()]
        public void RomanToIntTest()
        {
            int test1 = RomanNumber.RomanToInt("CLXVII");
            int expect1 = 167;
            Assert.AreEqual(expect1, test1);

            int test2 = RomanNumber.RomanToInt("MMMCMXCIX");
            int expect2 = 3999;
            Assert.AreEqual(expect2, test2);

            int test3 = RomanNumber.RomanToInt("I");
            int expect3 = 1;
            Assert.AreEqual(expect3, test3);

            int test4 = RomanNumber.RomanToInt("MDCLXVI");
            int expect4 = 1666;
            Assert.AreEqual(expect4, test4);
        }

        [TestMethod()]

        public void AddTest()
        {
            RomanNumber num1 = new RomanNumber(123);
            RomanNumber num2 = new RomanNumber(47);
            RomanNumber test = num1 + num2;
            string expect1 = "CLXX";
            Assert.AreEqual(expect1, test.ToString());

            RomanNumber numnull = null;
            RomanNumber num3 = new RomanNumber(47);
            Assert.ThrowsException<RomanNumberException>(() => (num3 + numnull));
            Assert.ThrowsException<RomanNumberException>(() => (numnull + num3));
            Assert.ThrowsException<RomanNumberException>(() => (numnull + numnull));
        }


        [TestMethod()]
        public void SubTest()
        {
            RomanNumber num1 = new RomanNumber(123);
            RomanNumber num2 = new RomanNumber(47);
            RomanNumber test = num1 - num2;
            string expect1 = "LXXVI";
            Assert.AreEqual(expect1, test.ToString());
            Assert.ThrowsException<RomanNumberException>(() => (num2 - num1));

            RomanNumber numnull = null;
            RomanNumber num3 = new RomanNumber(47);
            Assert.ThrowsException<RomanNumberException>(() => (num3 - numnull));
            Assert.ThrowsException<RomanNumberException>(() => (numnull - num3));
            Assert.ThrowsException<RomanNumberException>(() => (numnull - numnull));
        }

        [TestMethod()]
        public void MulTest()
        {
            RomanNumber num1 = new RomanNumber(12);
            RomanNumber num2 = new RomanNumber(47);
            RomanNumber test = num1 * num2;
            string expect1 = "DLXIV";
            Assert.AreEqual(expect1, test.ToString());

            RomanNumber numnull = null;
            RomanNumber num3 = new RomanNumber(47);
            Assert.ThrowsException<RomanNumberException>(() => (num3 * numnull));
            Assert.ThrowsException<RomanNumberException>(() => (numnull * num3));
            Assert.ThrowsException<RomanNumberException>(() => (numnull * numnull));
        }

        [TestMethod()]
        public void DivTest()
        {
            RomanNumber num1 = new RomanNumber(47);
            RomanNumber num2 = new RomanNumber(12);
            RomanNumber test = num1 / num2;
            string expect1 = "III";
            Assert.AreEqual(expect1, test.ToString());
            Assert.ThrowsException<RomanNumberException>(() => (num2 / num1));

            RomanNumber numnull = null;
            RomanNumber num3 = new RomanNumber(47);
            Assert.ThrowsException<RomanNumberException>(() => (num3 / numnull));
            Assert.ThrowsException<RomanNumberException>(() => (numnull / num3));
            Assert.ThrowsException<RomanNumberException>(() => (numnull / numnull));
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber num1 = new RomanNumber(123);
            string test1 = num1.ToString();
            string expect1 = "CXXIII";
            Assert.AreEqual(expect1, test1);

            RomanNumber num2 = new RomanNumber(5);
            string test2 = num2.ToString();
            string expect2 = "V";
            Assert.AreEqual(expect2, test2);

            RomanNumber num3 = new RomanNumber(3999);
            string test3 = num3.ToString();
            string expect3 = "MMMCMXCIX";
            Assert.AreEqual(expect3, test3);
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber expect1 = new RomanNumber(123);
            var test1 = (RomanNumber)expect1.Clone();
            Assert.AreEqual(expect1.ToString(), test1.ToString());

            RomanNumber expect2 = new RomanNumber(1);
            var test2 = (RomanNumber)expect2.Clone();
            Assert.AreEqual(expect2.ToString(), test2.ToString());

            RomanNumber expect3 = new RomanNumber(3999);
            var test3 = (RomanNumber)expect3.Clone();
            Assert.AreEqual(expect3.ToString(), test3.ToString());
        }

        [TestMethod()]
        public void CompareToTest()
        {
            RomanNumber num1 = new RomanNumber(123);
            RomanNumber num2 = new RomanNumber(1);
            RomanNumber num3 = new RomanNumber(3999);
            RomanNumber num4 = new RomanNumber(564);
            RomanNumber num5 = new RomanNumber(23);

            RomanNumber[] test = { num1, num2, num3, num4, num5 };
            RomanNumber[] expect = { num2, num5, num1, num4, num3 };

            Array.Sort(test);

            CollectionAssert.AreEqual(expect, test);

        }

        [TestMethod()]
        public void ConstructTest()
        {
            RomanNumber test1 = new RomanNumber(12);
            string expect1 = "XII";
            Assert.AreEqual(expect1, test1.ToString());

            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(0));
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(4000));
        }

    }
}