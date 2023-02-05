using Warehousee;


class Program
{
    public static void Main(string[] args)
    {
        Warehouse warehouse = new Warehouse();
        Product products = new Product();
        products.GenerateProducts();

        warehouse.Products = products.Products;
        warehouse.ChoiceInMenu();
    }
}
