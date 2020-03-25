using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace test_FizzBuzz
{
    [TestClass]
    public class TestFizzBuzz
    {
        [TestMethod]
        public void CallFizzBuzzMethod()
        {
            cls_FizzBuzz obj_FizzBuzz = new cls_FizzBuzz();
            Assert.AreEqual(null, obj_FizzBuzz.FizzBuzz(1));
        }
    }
}
