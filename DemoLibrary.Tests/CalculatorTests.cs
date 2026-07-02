using Xunit;

namespace DemoLibrary.Tests {
    public class CalculatorTests {

        [Fact]
        public void Add_ShouldReturnCorrectSumV1() {
            // Arrange (Expected)
            double expected = 8;
            // Act (Actual)
            double result = Calculator.Add(5, 3);
            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(21,5.25,26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        // [InlineData(x, y, expected)]
        public void Add_ShouldReturnCorrectSumV2
                (double x, double y, double expected) {

            // Arrange (Expected)
            
            // Act (Actual)
            double result = Calculator.Add(x, y);
            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(8,4,2)]
        public void Divide_ShouldReturnCorrectDivision
               (double x, double y, double expected) {

            // Arrange (Expected)

            // Act (Actual)
            double result = Calculator.Divide(x, y);
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_DivideBZero() {

            // Arrange (Expected)
            double expected = 0;
            // Act (Actual)
            double result = Calculator.Divide(15, 0);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
