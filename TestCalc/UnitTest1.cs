using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace TestCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd_Pass()
        {
            var input1 = "5";
            var input2 = "12";
            var result = CalcHelper.Add(input1, input2);
            Assert.AreEqual(17, result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only numbers are allowed.")]
        public void TestAdd_Fail()
        {
            var input1 = "a";
            var input2 = "12";
            _ = CalcHelper.Add(input1, input2);
        }

        [TestMethod]
        public void TestSubtract_Pass()
        {
            var input1 = "29.3";
            var input2 = "-0.1";
            var result = CalcHelper.Subtract(input1, input2);

            Assert.AreEqual("29.4", result.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only numbers are allowed.")]
        public void TestSubtract_Fail()
        {
            var input1 = "29.3";
            var input2 = "";
            _ = CalcHelper.Subtract(input1, input2);
        }

        [TestMethod]
        public void TestMultiply_Pass()
        {
            var input1 = "5";
            var input2 = "-6";
            var result = CalcHelper.Multiply(input1, input2);

            Assert.AreEqual("-30", result.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only numbers are allowed.")]
        public void TestMultiply_Fail()
        {
            var input1 = "29.3";
            var input2 = "a";
            _ = CalcHelper.Multiply(input1, input2);
        }

        [TestMethod]
        public void TestDivide_Pass()
        {
            var input1 = "99.9";
            var input2 = "3";
            var result = CalcHelper.Divide(input1, input2);

            Assert.AreEqual("33.3", result.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "Only numbers are allowed.")]
        public void TestDivide_Fail()
        {
            var input1 = "x";
            var input2 = "0";
            _ = CalcHelper.Divide(input1, input2);
        }
    }

    

}
