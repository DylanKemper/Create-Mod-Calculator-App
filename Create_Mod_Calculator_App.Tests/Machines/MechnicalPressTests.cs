using Create_Mod_Calculator_App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

        // Min should return 0 items/sec
        [TestMethod]
        public void Solve_0RPM_Returns_0ItemsPerSec()
        {
            var inputs = new Dictionary<string, double> { { "RPM", 0 } };

            double result = press.Solve("ItemsPerSec", inputs);
            Assert.AreEqual(0, result, 0.01);
        }

        // Max should return 2.54 items/sec
        [TestMethod]
        public void Solve_256RPM_Returns_2Point54_ItemsPerSec()
        {
            var inputs = new Dictionary<string, double> { { "RPM", 256 } };

            double result = press.Solve("ItemsPerSec", inputs);
            Assert.AreEqual(2.54167, result, 0.01);
        }

        // Middle value
        [TestMethod]
        public void Solve_128RPM_Returns_1Point31_ItemsPerSec()
        {
            var inputs = new Dictionary<string, double> { { "RPM", 128 } };

            double result = press.Solve("ItemsPerSec", inputs);
            Assert.AreEqual(1.31, result, 0.01);
        }

        // RPM > 256 should throw exception
        [TestMethod]
        public void Too_High_RPM_Throws_Exception()
        {
            var inputs = new Dictionary<string, double> { { "RPM", 300 } };

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => press.Solve("ItemsPerSec", inputs)
            );
        }

        // RPM < 0 should throw exception
        [TestMethod]
        public void Too_Low_RPM_Throws_Exception()
        {
            var inputs = new Dictionary<string, double> { { "RPM", -5 } };

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => press.Solve("ItemsPerSec", inputs)
            );
        }

        [TestMethod]
        public void Solve_0ItemsPerSec_Returns_0RPM()
        {
            var inputs = new Dictionary<string, double> { { "ItemsPerSec", 0 } };

            double result = press.Solve("RPM", inputs);
            Assert.AreEqual(0, result, 0.01);
        }

        [TestMethod]
        public void Solve_LessThanMinimumItemsPerSec_Returns_0RPM()
        {
            var inputs = new Dictionary<string, double> { { "ItemsPerSec", press.MinimumItemsPerSec } };

            double result = press.Solve("RPM", inputs);
            Assert.AreEqual(0, result, 0.01);
        }
    }
}