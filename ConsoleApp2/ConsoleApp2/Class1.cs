using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Product
    {
        public string ID;
        public string BrandName;
        public string Model;
        public int Price;
        public int Cost;
        public int Income;
        public int Count;
        public Product(string brandName, string model , int price, int cost, int count)
        {
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;
            Price = 0;

            if (count < 0)
            {
                count = 0;
            }

            
        }
    }
}
