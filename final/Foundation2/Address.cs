
class Address
{
    
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public string StreetAddress { get => streetAddress; set => streetAddress = value; }
    public string City { get => city; set => city = value; }
    public string State { get => state; set => state = value; }
    public string Country { get => country; set => country = value; }

    public Address(string streetAddress, string city, string state, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        State = state;
        Country = country;
    }

  
    public bool IsInUSA()
    {
        return Country.ToUpper() == "USA";
    }

   
    public string GetFullAddress()
    {
        return $"{StreetAddress}\n{City}, {State} {Country}";
    }
}
