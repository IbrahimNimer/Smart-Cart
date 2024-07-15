using System;
using System.Collections.Generic;
using System.Linq;

namespace Smart_Cart_Application
{
    public class ShoppingCart
    {
        private List<Product> items = new List<Product>();

        public List<Product> Items => items;

        public void AddProduct(Product product)
        {
            items.Add(product);
        }

        public bool RemoveProduct(string productName)
        {
            Product productToRemove = items.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
            if (productToRemove != null)
            {
                items.Remove(productToRemove);
                return true;
            }
            return false;
        }

        public void ViewCart()
        {
            int count =1;
            Console.WriteLine("Items in your cart:");
            foreach (var item in items)
            {
                Console.WriteLine($" {count}.{item.Name} - ${item.Details.Price} [{item.Details.Category}]");
                count++;
            }
        }

        public double CalculateTotal()
        {
            return items.Sum(item => item.Details.Price);
        }
    }
}



