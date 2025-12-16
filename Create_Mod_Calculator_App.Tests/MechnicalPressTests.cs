using Create_Mod_Calculator_App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Create_Mod_Calculator_App
{
    [TestClass]
    public class MechanicalPressTests
    {
        private MechanicalPress press;

        [TestInitialize]
        public void Setup()
        {
            press = new MechanicalPress();
        }

        [TestMethod]
        public void Solve_128RPM_Returns_1Point31_ItemsPerSec()
        {
            var inputs = new Dictionary<string, double> { { "RPM", 128 } };

            double result = press.Solve("ItemsPerSec", inputs);
            Assert.AreEqual(1.31, result, 0.01);
        }

        [TestMethod]
        public void Solve_0RPM_Returns_0_ItemsPerSec()
        {
            var inputs = new Dictionary<string, double> { { "RPM", 0 } };

            double result = press.Solve("ItemsPerSec", inputs);
            Assert.AreEqual(0, result, 0.01);
        }
    }
}