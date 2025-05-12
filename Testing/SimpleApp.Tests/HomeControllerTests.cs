using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SimpleApp.Controllers;
using SimpleApp.Models;
using Xunit;
namespace SimpleApp.Tests
{
    public class HomeControllerTests
    {
        class FakeDataSource : IDataSource
        {
            public FakeDataSource(Product[] data) => Products = data;
            public IEnumerable<Product> Products { get; }
        }

        [Fact]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            Product[] testData = new Product[]
            {
                new Product { Name = "P1", Price = 75.10M },
                new Product { Name = "P2", Price = 120M },
                new Product { Name = "P3", Price = 110M }
            };
            IDataSource data = new FakeDataSource(testData);
            var controller = new HomeController();
            controller.dataSource = data;

            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
            as IEnumerable<Product>;

            // Assert
            Assert.Equal(data.Products, model, Comparer.Get<Product>((p1, p2) => p1?.Name == p2?.name
                && p1?.Price == p2?.Price));
        }
    }
}

// Arrange serve para instanciar o que for necessário para os testes
// Act serve para chamar os métodos que vão ser alvo de teste
// Assert serve para usar as instâncias e os métodos para fazer os testes propriamente ditos