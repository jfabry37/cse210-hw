public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _zipCode;
    public Address (string street, string city, string state, string zipCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
        
    }
    public bool InUSA()
    {
     if (_country == "USA")
        {
            return true;
        } 
    else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_street} \n{_city}, {_state} \n{_zipCode} {_country}";
    }

}