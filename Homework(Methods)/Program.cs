using Warehousee;
class Program
{
    public static void Main(string[] args)
    {
        Warehouse warehouse = new Warehouse();
        Products products = new Products();
        products.GenerateProducts();

        warehouse.ProductsList = products.ProductsList;
        warehouse.ChoiceInMenu();
    }
}

