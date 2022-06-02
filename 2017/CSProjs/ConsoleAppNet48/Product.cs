using System;

namespace ConsoleAppNet48
{
    internal class Product
    {
        public string Name { get; internal set; }
        public DateTime Expiry { get; internal set; }
        public string[] Sizes { get; internal set; }
    }
}