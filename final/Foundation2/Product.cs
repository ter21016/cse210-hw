
class Product
{
    
    private string name;
    private string productId;
    private double price;
    private int quantity;

    
    public string Name { get => name; set => name = value; }
    public string ProductId { get => productId; set => productId = value; }
    public double Price { get => price; set => price = value; }
    public int Quantity { get => quantity; set => quantity = value; }

    
    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }
}

