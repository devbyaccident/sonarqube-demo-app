using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 1;
            int b = 2;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(3, result, "1 + 2 should equal 3");
        }
    }
}
