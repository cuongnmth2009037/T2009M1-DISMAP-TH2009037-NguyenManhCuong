using System;
using System.Collections.Generic;

namespace AutomatedProductManagement
{
    public class ApplicationProduct
    {
        private Dictionary<string, Product> _products = new Dictionary<string, Product>();

        public void AddProduct()
        {
            Product product = new Product();
            Console.WriteLine("Please enter Id: ");
            product.Id = Console.ReadLine();
            Console.WriteLine("Please enter name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Please enter price: ");
            product.Price = Console.ReadLine();
            _products.Add(product.Id, product);
        }

        public void DisplayProduct()
        {
            foreach (var list in _products)
            {
                Console.WriteLine("List of products:");
                Console.WriteLine($"{list.Value}");
            } 
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Please enter the id to delete: ");
            var id = Console.ReadLine();
            if (_products.ContainsKey(id))
            {
                _products.Remove(id);
                Console.WriteLine("Delete product successfully!");
            }
            else
            {
                Console.WriteLine("No products found!");
            }
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("------------Automated Product Management-------------- ");
                Console.WriteLine("1. Add product records.");
                Console.WriteLine("2. Display product records.");
                Console.WriteLine("3. Delete product by Id.");
                Console.WriteLine("4. Exit.");
                Console.WriteLine("Please choose (1-4): ");
                Console.WriteLine("--------------------------------------------------------");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        DisplayProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        Console.WriteLine("Bye!Bye");
                        break;
                    default:
                        Console.WriteLine("Wrong choice, please choose again!");
                        break;
                }
                Console.ReadLine();
                if (choice == 0)
                {
                    break;
                }
            }
        }
    }
}