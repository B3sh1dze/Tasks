using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Warehousee
{
    public class Warehouse
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public bool IsProductNameValid(string name)
        {
            if (name == null)
            {
                return false;
            }
            else if (Regex.IsMatch(name, @"^\d"))
            {
                return false;
            }
            else if (name.StartsWith(" ") || name.EndsWith(" "))
            {
                return false;
            }
            else if (name.Length > 50)
            {
                return false;
            }
            foreach (var item in Products)
            {
                if (name == item.Name)
                {
                    return false;
                }
            }
            return true;
        }
        public void RegisterProduct()
        {
            Console.Write("Please enter products name: ");
            var name = Console.ReadLine();
            bool isProductNameValid = IsProductNameValid(name);
            if (isProductNameValid)
            {
                var category = ChooseCategory();
                Console.WriteLine();
                Console.Write("Enter price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter stock amount: ");
                int stock = Convert.ToInt32(Console.ReadLine());
                var isPriceAndStockCorrect = IsProductPriceAndStockValid(price, stock);
                if (isPriceAndStockCorrect)
                {
                    var product = new Product(name, category, price, stock);
                    Products.Add(product);
                    Console.WriteLine();
                    Console.WriteLine("You successfuly added product: ");
                    Console.WriteLine(product);
                }
                else
                {
                    Console.WriteLine("Wrong format.");
                }
            }
            else
            {
                Console.WriteLine("Wrong format.");
            }
        }
        public bool IsProductPriceAndStockValid(double price, int stock)
        {
            if (price <= 0 || stock < 0)
            {
                return false;
            }
            return true;
        }
        public void UpdateProductPriceAndAmount()
        {
            Console.Clear();
            ShowAllProducts();
            Console.Write("Choose product you want to Change: ");
            var userChoice = Convert.ToInt32(Console.ReadLine());
            var usersChoice = Products[userChoice - 1];
            Console.WriteLine("You chose: ");
            Console.WriteLine(usersChoice);
            Console.Write("Enter new Price: ");
            var newPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter new stock amount: ");
            var newStock = Convert.ToInt32(Console.ReadLine());
            usersChoice.Price = newPrice;
            usersChoice.Stock = newStock;
            Console.Clear();
            Console.WriteLine("Changed Product: ");
            Console.WriteLine(usersChoice);
        }
        public void RemoveRegisteredProduct()
        {
            ShowAllProducts();
            Console.Write("Choose product you want to remove: ");
            var userChoice = Convert.ToInt32(Console.ReadLine());
            var usersChoice = Products[userChoice - 1];
            Products.Remove(usersChoice);
            Console.Clear();
            Console.WriteLine("You removed: ");
            Console.WriteLine(usersChoice);
            Console.WriteLine();
        }
        public void ShowAllProducts()
        {
            Console.Clear();
            int i = 1;
            foreach (var item in Products)
            {
                Console.Write(i + ". ");
                Console.WriteLine(item.ToString());
                i++;
            }
        }
        public string ChooseCategory()
        {
            Console.WriteLine("Please choose products category: ");
            var product = new Product();
            int i = 1;
            foreach (var item in product.PossibleCategories)
            {
                Console.Write(i + ". ");
                Console.WriteLine(item);
                i++;
            }
            var categoryChoice = Console.ReadKey().Key;
            if (categoryChoice == ConsoleKey.D1)
            {
                return "Dry Food";
            }
            else if (categoryChoice == ConsoleKey.D2)
            {
                return "Diary";
            }
            else if (categoryChoice == ConsoleKey.D3)
            {
                return "Sports Inventory";
            }
            else if (categoryChoice == ConsoleKey.D4)
            {
                return "Beverages";
            }
            else
            {
                return null;
            }
        }
        public void DisplayWarehouseOptionsMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Register Products");
            Console.WriteLine("2 - Update products price and amount");
            Console.WriteLine("3 - Remove registered product");
            Console.WriteLine("4 - Show all products");
            Console.WriteLine("5 - Exit");
        }
        public void ChoiceInMenu()
        {
            while (true)
            {
                DisplayWarehouseOptionsMenu();
                var choice = Console.ReadKey().Key;
                if (choice == ConsoleKey.D1)
                {
                    Console.WriteLine();
                    RegisterProduct();
                }
                else if (choice == ConsoleKey.D2)
                {
                    Console.WriteLine();
                    UpdateProductPriceAndAmount();
                }
                else if (choice == ConsoleKey.D3)
                {
                    Console.WriteLine();
                    RemoveRegisteredProduct();
                }
                else if (choice == ConsoleKey.D4)
                {
                    Console.WriteLine();
                    ShowAllProducts();
                }
                else if (choice == ConsoleKey.D5)
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for visiting.");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong input. try again!");
                }
            }
        }
    }
}

