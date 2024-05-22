class Program
{
    static void Main(string[] args)
    {
        ProductCatalog catalog = new ProductCatalog();

        catalog.Add(new Product("Laptop", 1200, ProductType.Electronics));
        catalog.Add(new Product("T-shirt", 20, ProductType.Clothing));
        catalog.Add(new Product("Book", 15, ProductType.Books));
        catalog.Add(new Product("Bananas", 2, ProductType.Groceries));

        List<Product> allProducts = catalog.GetAll();
        Console.WriteLine("All products:");
        foreach (var product in allProducts)
        {
            Console.WriteLine($"{product.Name} - ${product.Price} - {product.Type}");
        }

        ProductType searchType = ProductType.Electronics;
        List<Product> electronicsProducts = catalog.GetAllProductsByType(searchType);
        Console.WriteLine($"\n{searchType} products:");
        foreach (var product in electronicsProducts)
        {
            Console.WriteLine($"{product.Name} - ${product.Price}");
        }
    }
}