using Newtonsoft.Json;
using System;

namespace ConsoleAppNet48
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product
            {
                Name = "Apple",
                Expiry = new DateTime(2008, 12, 28),
                Sizes = new string[] { "Small" }
            };

            string json = JsonConvert.SerializeObject(product);
        }
    }
}
