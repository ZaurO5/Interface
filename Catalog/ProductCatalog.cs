public class ProductCatalog
{
    private List<Product> products;
    public ProductCatalog()
    {
        products = new List<Product>();
    }
    public void Add(Product product)
    {
        products.Add(product);
    }
    public List<Product> GetAll()
    {
        return products;
    }
    public List<Product> GetAllProductsByType(ProductType type)
    {
        return products.Where(p => p.Type == type).ToList();
    }
}
