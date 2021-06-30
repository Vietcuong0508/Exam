using System;

namespace DISM_AP
{
    public class Product
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string productId, string name, double price)
        {
            ProductID = productId;
            Name = name;
            Price = price;
        }

        public Product()
        {
        }
        
        public override string ToString()
        {
            return $"ProductID : {ProductID} \t Name : {Name} \t Price : {Price} ";
        }
    }
}