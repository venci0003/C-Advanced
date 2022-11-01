using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,double>> storeProductsInformation = new Dictionary<string, Dictionary<string,double>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Revision")
                {
                    break;
                }
                string []tokens = command.Split(", ");
               
                string foodShopName = tokens[0];
                string productName = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!storeProductsInformation.ContainsKey(foodShopName))
                {
                    storeProductsInformation[foodShopName] = new Dictionary<string, double>();
                    storeProductsInformation[foodShopName].Add(productName, price);
                }
                else
                {
                    storeProductsInformation[foodShopName].Add(productName, price);
                }
            }
           storeProductsInformation =  storeProductsInformation.OrderBy(n => n.Key).ToDictionary(x => x.Key, x=> x.Value);

            foreach (var store in storeProductsInformation)
            {
                Console.WriteLine($"{store.Key}->");
                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
