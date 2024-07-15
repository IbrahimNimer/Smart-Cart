using System;
using System.Collections.Generic;

namespace Smart_Cart_Application
{
    public class GroceryStore
    {
        private List<Product> products;

        public GroceryStore()
        {
            products = new List<Product>
            {
                new Product("Apple", new Product.ProductDetails(Product.ProductCategory.Food, 1.99)),
                new Product("Banana", new Product.ProductDetails(Product.ProductCategory.Food, 0.99)),
                new Product("Orange", new Product.ProductDetails(Product.ProductCategory.Food, 1.49)),
                new Product("Bread", new Product.ProductDetails(Product.ProductCategory.Food, 2.50)),
                new Product("Milk", new Product.ProductDetails(Product.ProductCategory.Food, 1.20)),
                new Product("Cheese", new Product.ProductDetails(Product.ProductCategory.Food, 3.99)),
                new Product("Eggs", new Product.ProductDetails(Product.ProductCategory.Food, 2.79)),
                new Product("Chicken", new Product.ProductDetails(Product.ProductCategory.Food, 5.99)),
                new Product("Fish", new Product.ProductDetails(Product.ProductCategory.Food, 6.99)),
                new Product("Rice", new Product.ProductDetails(Product.ProductCategory.Food, 1.89))
            };
        }

        public List<Product> GetAvailableProducts()
        {
            return products;
        }
    }
}
