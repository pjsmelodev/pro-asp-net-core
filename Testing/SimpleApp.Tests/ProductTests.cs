using SimpleApp.Models;
using Xunit;

namespace SimpleApp.Tests
{
    public class ProductTests
    {
        [Fact]
        public void CanChangeProductName()
        {
            // Arrange
            var p = new Product { Name = "Test", Price = 100M };

            // Act
            p.Name = "New Name";

            // Assert
            Assert.Equal("New Name", p.Name);
        }

        // [Fact] indica que se trata de um teste
        [Fact]
        public void CanChangeProductPrice()
        {
            // Arrange
            // Arrange refers to setting up the conditions for the test
            var p = new Product { Name = "Test", Price = 100M };

            // Act
            // Act refers to performing the test
            p.Price = 200M;

            // Assert
            // Assert refers to verifying that the result was the expected one
            Assert.Equal(100M, p.Price);
        }
    }

    // o nome do teste deve descrever o que ele faz
    // o nome da classe deve descrever o que ela testa especificamente
}