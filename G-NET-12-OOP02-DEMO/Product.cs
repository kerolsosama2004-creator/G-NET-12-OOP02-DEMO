using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP02_DEMO
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public static int TotalProducts;
        //---------------
        //Static Constructor
        // Can Not Take Parameters
        // Can Not Called Directly
        //Called Once Per Application Liftime
        //Before Creating Any Object From  The Class Or Accessing Any  Static Member

        static Product()
        {
            Console.WriteLine("Product Static Constructor");
            TotalProducts = 0;
        }
        public Product(string _Name, decimal _Price)
        {
            Name = _Name;
            Price = _Price;
            TotalProducts++;
            Id = TotalProducts;
        }
        public override string ToString()
        {
            return $"{Id}: {Name}:{Price:c}";
        }
    }
}
