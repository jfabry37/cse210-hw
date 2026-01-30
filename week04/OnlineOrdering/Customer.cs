public class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public int ShippingCost()
    {
        if (_address.InUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label: \n{_name},\n{_address.GetAddress()}";
    }

}