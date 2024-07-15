using System;
using System.Collections.Generic;

namespace Smart_Cart_Application
{
    public class ElectronicsStore
    {
        private List<Product> products;

        public ElectronicsStore()
        {
            products = new List<Product>
            {
                new Product("Laptop", new Product.ProductDetails(Product.ProductCategory.Electronics, 999.99)),
                new Product("Headphones", new Product.ProductDetails(Product.ProductCategory.Electronics, 199.99)),
                new Product("Smartphone", new Product.ProductDetails(Product.ProductCategory.Electronics, 699.99)),
                new Product("TV", new Product.ProductDetails(Product.ProductCategory.Electronics, 499.99)),
                new Product("Camera", new Product.ProductDetails(Product.ProductCategory.Electronics, 299.99)),
                new Product("Tablet", new Product.ProductDetails(Product.ProductCategory.Electronics, 399.99)),
                new Product("Smartwatch", new Product.ProductDetails(Product.ProductCategory.Electronics, 249.99)),
                new Product("Speaker", new Product.ProductDetails(Product.ProductCategory.Electronics, 149.99)),
                new Product("Monitor", new Product.ProductDetails(Product.ProductCategory.Electronics, 199.99)),
                new Product("Printer", new Product.ProductDetails(Product.ProductCategory.Electronics, 129.99))
            };
        }

        public List<Product> GetAvailableProducts()
        {
            return products;
        }
    }
}
