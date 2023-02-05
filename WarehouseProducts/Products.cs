using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Warehousee
{
    public class Products : Warehouse
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; } = new Random().NextDouble() * 22 + 3;
        public int Stock { get; set; } = new Random().Next(5, 30);
        public List<string> PossibleCategories = new List<string> { "Dry Food", "Diary", "Sports Inventory", "Beverages" };
        public Products()
        {

        }
        public Products(string name, string category)
        {
            Name = name;
            Category = category;
        }
        public Products(double price, int stock)
        {
            Price = price;
            Stock = stock;
        }
        public Products(string name, string category, double price, int stock)
        {
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }
        public void GenerateProducts()
        {
            var productNames = new List<string>()
            {
                "Milk",
                "Crisps",
                "Espander",
                "Sparkling Water",
                "Yogurt",
                "Beer"
            };
            var productCategory = new List<string>()
            {
                "Diary",
                "Dry Food",
                "Sprost Inventory",
                "Beverages",
                "Diary",
                "Beverages"
            };
            var products = new List<Products>();
            for (int i = 0; i < productNames.Count; i++)
            {
                var product = new Products()
                {
                    Name = productNames[i],
                    Category = productCategory[i],
                };
                ProductsList.Add(product);
            }
        }
        public override string ToString()
        {
            double roundedNumber = Math.Round(Price, 2);
            return
                $"name: {Name}\n" +
                $"Category: {Category}\n" +
                $"price: {roundedNumber}\n" +
                $"stock: {Stock}";
        }
    }
}
