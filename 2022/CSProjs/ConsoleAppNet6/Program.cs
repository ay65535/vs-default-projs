// https://www.newtonsoft.com/json

using ConsoleAppNet6;
using Newtonsoft.Json;

Product product = new();
product.Name = "Apple";
product.Expiry = new DateTime(2008, 12, 28);
product.Sizes = new string[] { "Small" };

string _ = JsonConvert.SerializeObject(product);
