using System;
using System.Collections.Generic;
using System.Text;

namespace DISM_AP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            ProductManager productManager = new ProductManager();
            while (true)
            {
                Console.WriteLine("\n=============================");
                Console.WriteLine("1. Add product records");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                Console.WriteLine("=============================\n");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        productManager.Add();
                        break;
                    case 2:
                        productManager.DisplayAll();
                        break;
                    case 3:
                        productManager.Delete();
                        break;
                    case 4:
                        Console.WriteLine("Bye Bye!");
                        break;
                }

                if (choice == 4)
                {
                    break;
                }
            }
        }
    }
}