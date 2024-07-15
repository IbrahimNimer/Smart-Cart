using System;

namespace Smart_Cart_Application
{
    public class Product
    {
        public enum ProductCategory
        {
            Food,
            Clothing,
            Electronics
        }

        public class ProductDetails
        {
            public ProductCategory Category { get; }
            public double Price { get; }

            public ProductDetails(ProductCategory category, double price)
            {
                Category = category;
                Price = price;
            }
        }

        public string Name { get; set; }
        public ProductDetails Details { get; set; }

        public Product(string name, ProductDetails details)
        {
            Name = name;
            Details = details;
        }
    }
}
