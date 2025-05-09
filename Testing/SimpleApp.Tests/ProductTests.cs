using SimpleApp.Models;
using Xunit;

namespace SimpleApp.Tests
{

    [Fact]
    // o erro é, para já, intencional
    public void CanChangeProductName()
    {
        // Arrange
        var p = new Product { Name = "Test", Price = 100M };

        // Act
        p.Name = "New Name";

        // Assert
        Assert.Equal("New Name", p.Name);
    }

    [Fact]
    public void CanChangeProductPrice()
    {
        // Arrange
        var p = new Product { Name = "Test", Price = 100M };

        // Act
        p.Price = 200M;

        // Assert
        Assert.Equal(100M, p.Price);
    }
}