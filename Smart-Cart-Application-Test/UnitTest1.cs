using System;
using Xunit;
using Smart_Cart_Application;

namespace Smart_Cart_Application.Tests
{
    public class ShoppingCartTests
    {
        [Fact]
        public void AddProduct()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product("Laptop", new Product.ProductDetails(Product.ProductCategory.Electronics, 999.99));

            // Act
            cart.AddProduct(product);

            // Assert
            Assert.Contains(product, cart.Items);
        }

        [Fact]
        public void RemoveProduct()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product("Laptop", new Product.ProductDetails(Product.ProductCategory.Electronics, 999.99));
            cart.AddProduct(product);

            // Act
            bool removed = cart.RemoveProduct("Laptop");

            // Assert
            Assert.True(removed);
            Assert.DoesNotContain(product, cart.Items);
        }

        [Fact]
        public void CalculateTotal()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product1 = new Product("Laptop", new Product.ProductDetails(Product.ProductCategory.Electronics, 999.99));
            var product2 = new Product("Headphones", new Product.ProductDetails(Product.ProductCategory.Electronics, 199.99));
            cart.AddProduct(product1);
            cart.AddProduct(product2);

            // Act
            double total = cart.CalculateTotal();

            // Assert
            Assert.Equal(1199.98, total, 2); 
        }
    }
}
