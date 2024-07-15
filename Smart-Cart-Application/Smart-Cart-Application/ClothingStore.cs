using System;
using System.Collections.Generic;

namespace Smart_Cart_Application
{
    public class ClothingStore
    {
        private List<Product> products;

        public ClothingStore()
        {
            products = new List<Product>
            {
                new Product("T-Shirt", new Product.ProductDetails(Product.ProductCategory.Clothing, 14.99)),
                new Product("Jeans", new Product.ProductDetails(Product.ProductCategory.Clothing, 39.99)),
                new Product("Jacket", new Product.ProductDetails(Product.ProductCategory.Clothing, 49.99)),
                new Product("Dress", new Product.ProductDetails(Product.ProductCategory.Clothing, 29.99)),
                new Product("Hat", new Product.ProductDetails(Product.ProductCategory.Clothing, 9.99)),
                new Product("Sweater", new Product.ProductDetails(Product.ProductCategory.Clothing, 24.99)),
                new Product("Skirt", new Product.ProductDetails(Product.ProductCategory.Clothing, 19.99)),
                new Product("Shoes", new Product.ProductDetails(Product.ProductCategory.Clothing, 59.99)),
                new Product("Socks", new Product.ProductDetails(Product.ProductCategory.Clothing, 4.99)),
                new Product("Gloves", new Product.ProductDetails(Product.ProductCategory.Clothing, 7.99))
            };
        }

        public List<Product> GetAvailableProducts()
        {
            return products;
        }
    }
}
