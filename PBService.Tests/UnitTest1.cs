using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PBService.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get999_ShouldRetrunERR()
        {
            PBService.Controllers.MobileController mc = new Controllers.MobileController();

            var result = mc.Get("999");
            Assert.AreEqual(result, "ERR");
        }

        [TestMethod]
        public void Get381_ShouldRetrunERR()
        {
            PBService.Controllers.MobileController mc = new Controllers.MobileController();

            var result = mc.Get("381");
            Assert.AreEqual(result, "ERR");
        }

        [TestMethod]
        public void Get38164_ShouldRetrunMTS()
        {
            PBService.Controllers.MobileController mc = new Controllers.MobileController();
            // !(num.len > 5)
            var result = mc.Get("38164");
            Assert.AreEqual(result, "ERR");
        }

        [TestMethod]
        public void Get38163559369_ShouldRetrunTEL()
        {
            PBService.Controllers.MobileController mc = new Controllers.MobileController();

            var result = mc.Get("38163559369");
            Assert.AreEqual(result, "TEL");
        }
        [TestMethod]
        public void Get38163593318_ShouldRetrunMTS()
        {
            PBService.Controllers.MobileController mc = new Controllers.MobileController();

            var result = mc.Get("38163593318");
            Assert.AreEqual(result, "MTS");
        }
    }
}
