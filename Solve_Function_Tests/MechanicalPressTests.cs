using Create_Mod_Calculator_App;
using System.Diagnostics.Contracts;

namespace Solve_Function_Tests
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
    }
}