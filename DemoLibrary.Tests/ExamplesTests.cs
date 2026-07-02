using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DemoLibrary.Tests {
    public class ExamplesTests {

        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldWork() {
            // Arrange
            string file = "This is a valid file name";
            // Act & Assert
            string actual =  Examples.ExampleLoadTextFile(file);

            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void ExampleLoadTextFile_InvalidNameShouldFail() {

            Assert.Throws<ArgumentException>("file",() => Examples.ExampleLoadTextFile(""));
        }
    }
}
