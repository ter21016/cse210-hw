

class Customer
{
    
    private string name;
    private Address address;

    
    public string Name { get => name; set => name = value; }
    public Address Address { get => address; set => address = value; }

    
    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }
    public bool LivesInUSA()
    {
        return Address.IsInUSA();
    }
}

