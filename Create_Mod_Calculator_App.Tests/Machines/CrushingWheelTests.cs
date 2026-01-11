using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Create_Mod_Calculator_App
{
    [TestClass]
    public class CrushingWheelTests
    {
        private CrushingWheel wheel;

        [TestInitialize]
        public void Setup()
        {
            wheel = new CrushingWheel();
        }

        [TestMethod]
        public void Solve_0RPM_Returns_0ItemsPerSec()
        { 
            var inputs = new Dictionary<string, double> { { "RPM", 0 }, { "StackSize", 64}, { "RecipeDuration", 250 }, { "InputDelay", 1 } };
            double result = wheel.Solve("ItemsPerSec", inputs);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [DataRow(256.0, 64.0, 250.0, 1.0, 18.44837)]
        [DataRow(256.0, 64.0, 250.0, 3.0, 17.93149)]
        [DataRow(256.0, 64.0, 250.0, 27.0, 13.41961)]
        [DataRow(256.0, 32.0, 250.0, 1.0, 11.00558)]
        [DataRow(256.0, 16.0, 250.0, 1.0, 6.81985)]
        [DataRow(256.0, 7.0, 250.0, 1.0, 4.17563)]
        public void Solve_ItemsPerSec_WithVariousInputs_ReturnsCorrectValues(double rpm, double stackSize, double recipeDuration, double inputDelay, double expected)
        {
            var inputs = new Dictionary<string, double>
            {
                { "RPM", rpm },
                { "StackSize", stackSize },
                { "RecipeDuration", recipeDuration },
                { "InputDelay", inputDelay }
            };

            double actual = wheel.Solve("ItemsPerSec", inputs);

            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}
