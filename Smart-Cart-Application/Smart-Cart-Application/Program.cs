using System;

namespace Smart_Cart_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothingStore = new ClothingStore();
            var electronicsStore = new ElectronicsStore();
            var groceryStore = new GroceryStore();

            var cart = new ShoppingCart();
            var productGenerator = new ProductGenerator();

            while (true)
            {
                Console.Clear();
                Menu();

                string choice = Console.ReadLine()?.Trim().ToLower();

                switch (choice)
                {
                    case "1":
                        ClothingShopping(clothingStore, cart);
                        break;
                    case "2":
                        ElectronicsShopping(electronicsStore, cart);
                        break;
                    case "3":
                        GroceryShopping(groceryStore, cart);
                        break;
                    case "4":
                        ViewCart(cart);
                        break;
                    case "5":
                        AddRandomProducts(cart, productGenerator);
                        break;
                    case "6":
                        Checkout(cart);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void Menu()
        {
            Console.WriteLine("Welcome to the Smart Cart Application!");
            Console.WriteLine("1. Shop at Clothing Store");
            Console.WriteLine("2. Shop at Electronics Store");
            Console.WriteLine("3. Shop at Grocery Store");
            Console.WriteLine("4. View Shopping Cart");
            Console.WriteLine("5. Add Random Products to Cart");
            Console.WriteLine("6. Checkout and Exit");
            Console.Write("Enter your choice: ");
        }

        static void ClothingShopping(ClothingStore store, ShoppingCart cart)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Clothing Store!");
            Console.WriteLine("Available Products:");

            var products = store.GetAvailableProducts();

            bool shopping = true;
            while (shopping)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i].Name} - ${products[i].Details.Price} - {products[i].Details.Category}");
                }

                Console.Write("Enter the number of the product to add to cart (0 to cancel shopping): ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= products.Count)
                {
                    Product selectedProduct = products[choice - 1];
                    cart.AddProduct(selectedProduct);
                    Console.WriteLine($"{selectedProduct.Name} added to cart.");
                }
                else if (choice == 0)
                {
                    shopping = false;
                    Console.WriteLine("Shopping canceled. Returning to main menu.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }

        static void ElectronicsShopping(ElectronicsStore store, ShoppingCart cart)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Electronics Store!");
            Console.WriteLine("Available Products:");
              

            var products = store.GetAvailableProducts();

            bool shopping = true;
            while (shopping)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i].Name} - ${products[i].Details.Price} - {products[i].Details.Category}");
                }

                Console.Write("Enter the number of the product to add to cart (0 to cancel shopping): ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= products.Count)
                {
                    Product selectedProduct = products[choice - 1];
                    cart.AddProduct(selectedProduct);
                    Console.WriteLine($"{selectedProduct.Name} added to cart.");
                }
                else if (choice == 0)
                {
                    shopping = false;
                    Console.WriteLine("Shopping canceled. Returning to main menu.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }

        static void GroceryShopping(GroceryStore store, ShoppingCart cart)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Grocery Store!");
            Console.WriteLine("Available Products:");

            var products = store.GetAvailableProducts();

            bool shopping = true;
            while (shopping)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i].Name} - ${products[i].Details.Price} - {products[i].Details.Category}");
                }

                Console.Write("Enter the number of the product to add to cart (0 to cancel shopping): ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= products.Count)
                {
                    Product selectedProduct = products[choice - 1];
                    cart.AddProduct(selectedProduct);
                    Console.WriteLine($"{selectedProduct.Name} added to cart.");
                }
                else if (choice == 0)
                {
                    shopping = false;
                    Console.WriteLine("Shopping canceled. Returning to main menu.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }

        static void ViewCart(ShoppingCart cart)
        {
            Console.Clear();
            cart.ViewCart();
            Console.WriteLine($"Total: ${cart.CalculateTotal()}");

            Console.WriteLine("Do you want to remove any product? Y/N");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "y")
            {
                Console.WriteLine("Enter the name of the product you want to remove:");
                string productName = Console.ReadLine().Trim();

                if (cart.RemoveProduct(productName))
                {
                    Console.WriteLine($"{productName} removed from cart.");
                }
                else
                {
                    Console.WriteLine($"Product '{productName}' not found in cart.");
                }
            }
        }

        static void AddRandomProducts(ShoppingCart cart, ProductGenerator generator)
        {

            Console.Clear();
            Console.Write("Enter the number of random products to add: ");
            if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
            {
                
                for (int i = 0; i < count; i++)
                {
                    Product randomProduct = generator.GenerateProduct();
                    cart.AddProduct(randomProduct);
                    Console.WriteLine($"{i+1}.{randomProduct.Name} added to your cart.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Returning to main menu.");
            }
        }

        static void Checkout(ShoppingCart cart)
        {
            Console.Clear();
            Console.WriteLine("Checking out...");
            cart.ViewCart();
            Console.WriteLine($"Total: ${cart.CalculateTotal()}");
            Console.WriteLine("Thank you for shopping with us!");
        }


    }
}
