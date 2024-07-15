using System;

namespace Smart_Cart_Application
{
    public class ProductGenerator
    {
        private readonly Random random;

        public ProductGenerator()
        {
            random = new Random();
        }

        public Product GenerateProduct()
        {
            
            Product[] products = new Product[]
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
                new Product("Rice", new Product.ProductDetails(Product.ProductCategory.Food, 1.89)),

                new Product("Laptop", new Product.ProductDetails(Product.ProductCategory.Electronics, 999.99)),
                new Product("Headphones", new Product.ProductDetails(Product.ProductCategory.Electronics, 199.99)),
                new Product("Smartphone", new Product.ProductDetails(Product.ProductCategory.Electronics, 699.99)),
                new Product("TV", new Product.ProductDetails(Product.ProductCategory.Electronics, 499.99)),
                new Product("Camera", new Product.ProductDetails(Product.ProductCategory.Electronics, 299.99)),
                new Product("Tablet", new Product.ProductDetails(Product.ProductCategory.Electronics, 399.99)),
                new Product("Smartwatch", new Product.ProductDetails(Product.ProductCategory.Electronics, 249.99)),
                new Product("Speaker", new Product.ProductDetails(Product.ProductCategory.Electronics, 149.99)),
                new Product("Monitor", new Product.ProductDetails(Product.ProductCategory.Electronics, 199.99)),
                new Product("Printer", new Product.ProductDetails(Product.ProductCategory.Electronics, 129.99)),

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

            
            int randomIndex = random.Next(products.Length);
            return products[randomIndex];
        }
    }
}
