using BigPurpleBankWebApi.Controllers;
using BigPurpleBankWebApi.Models;
using BigPurpleBankWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BigPurpleBankWebApi.Test
{
    public class UnitTest1
    {
        private readonly ProductController _controller;
        private readonly IProductService _service;

        public UnitTest1()
        {
            _service = new ProductService();
            _controller = new ProductController(_service);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetProducts();

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.GetProducts() as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<Product>>(okResult?.Value);
            Assert.Equal(10, items.Count);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsNull()
        {
            // Act
            var okResult = _controller.GetProducts() as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<Product>>(okResult?.Value);
            Assert.NotNull(items);
        }
    }
}