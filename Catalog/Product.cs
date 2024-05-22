public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ProductType Type { get; set; }

    public Product(string name, decimal price, ProductType type)
    {
        Name = name;
        Price = price;
        Type = type;
    }
}