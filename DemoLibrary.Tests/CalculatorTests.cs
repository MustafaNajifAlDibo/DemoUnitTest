using Xunit;

namespace DemoLibrary.Tests {
    public class CalculatorTests {

        [Fact]
        public void Add_ShouldReturnCorrectSum() {
            // Arrange (Expected)
            double expected = 8;
            // Act (Actual)
            double result = Calculator.Add(5, 3);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
