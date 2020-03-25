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

        [TestMethod]
        public void ReturnFizzWhenNumberIsMultipleOf3()
        {
            cls_FizzBuzz obj_FizzBuzz = new cls_FizzBuzz();
            Assert.AreEqual("Fizz", obj_FizzBuzz.FizzBuzz(3));
            Assert.AreEqual("Fizz", obj_FizzBuzz.FizzBuzz(6));
        }

        [TestMethod]
        public void ReturnBuzzWhenNumberIsMultipleOf5()
        {
            cls_FizzBuzz obj_FizzBuzz = new cls_FizzBuzz();
            Assert.AreEqual("Buzz", obj_FizzBuzz.FizzBuzz(5));
            Assert.AreEqual("Buzz", obj_FizzBuzz.FizzBuzz(10));
        }

        [TestMethod]
        public void ReturnFizzBuzzWhenNumberIsMultipleOf3And5()
        {
            cls_FizzBuzz obj_FizzBuzz = new cls_FizzBuzz();
            Assert.AreEqual("FizzBuzz", obj_FizzBuzz.FizzBuzz(15));
            Assert.AreEqual("FizzBuzz", obj_FizzBuzz.FizzBuzz(30));
        }
    }
}
