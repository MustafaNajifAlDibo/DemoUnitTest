using Xunit;
using DemoLibrary.Models;

namespace DemoLibrary.Tests {
    public class DataAccessTests {

        [Fact]
        public void AddPersonToPeopleList_ShouldWork() {
            // Arrange
            var people = new List<PersonModel>();
            var person = new PersonModel { FirstName = "John", LastName = "Doe" };
            // Act
            DataAccess.AddPersonToPeopleList(people, person);
            // Assert
            Assert.Single(people); // Check that the list has one person
            Assert.Equal("John", people[0].FirstName); // Check that the first name is correct
            Assert.Equal("Doe", people[0].LastName); // Check that the last name is correct
        }

        [Theory]
        [InlineData("Tim","","LastName")]
        [InlineData("", "Corey", "FirstName")]
        public void AddPersonToPeopleList_ShouldFail
            (string firstName, string lastName, string param) {
           
            var people = new List<PersonModel>();
            var person = new PersonModel { FirstName = firstName, LastName = lastName };

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, person));
        }
    }
}
