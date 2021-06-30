using System;
using System.Collections.Generic;

namespace DISM_AP
{
    public class ProductManager
    {
        private static Dictionary<string, Product> products = new Dictionary<string, Product>();

        public void Add()
        {
            Console.WriteLine("Please enter ProductID:");
            var productId = Console.ReadLine();
            Console.WriteLine("Please enter name:");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter price:");
            var price = Convert.ToDouble(Console.ReadLine());
            products.Add(productId, new Product
            {
                ProductID = productId,
                Name = name,
                Price = price
            });
        }

        public void DisplayAll()
        {
            if (products.Count > 0)
            {
                foreach (var key in products.Keys)
                {
                    Console.WriteLine(products[key].ToString());
                }

                return;
            }

            Console.WriteLine("No product to show!");
        }

        public void Delete()
        {
            Console.WriteLine("Enter id product you want delete:");
            var productId = Console.ReadLine();
            if (products.ContainsKey(productId))
            {
                products.Remove(productId);
                Console.WriteLine("Delete success!");
            }
            else
            {
                Console.WriteLine($"No product were found with id {productId}");
            }
        }
    }
}