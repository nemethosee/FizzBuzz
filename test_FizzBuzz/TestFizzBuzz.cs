using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace test_FizzBuzz
{
    [TestClass]
    public class TestFizzBuzz
    {
        [TestMethod]
        public void ReturnTheNumberReceivedAsParam()
        {
            cls_FizzBuzz obj_FizzBuzz = new cls_FizzBuzz();
            Assert.AreEqual("1", obj_FizzBuzz.FizzBuzz(1));
            Assert.AreEqual("2", obj_FizzBuzz.FizzBuzz(2));
        }
    }
}
