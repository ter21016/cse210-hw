
class Order
{
  
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    
    public List<Product> Products { get => products; set => products = value; }
    public Customer Customer { get => customer; set => customer = value; }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach (Product product in Products)
        {
            totalCost += product.GetTotalCost();
        }

        if (Customer.LivesInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    
    public string GetPackingLabel()
    {
        string label = "**Packing List **\n";
        foreach (Product product in Products)
        {
            label += $" - {product.Name} ({product.ProductId})\n";
        }
        return label;
    }


    public string GetShippingLabel()
    {
        return $"** Shipping Label **\n To: {Customer.Name}\n {Customer.Address.GetFullAddress()}";
    }
}
