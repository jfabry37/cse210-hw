public class Orders
{
    private decimal _totalPrice;
    private List<Product>_products;
    private Customer _customer;
    
    public Orders (Customer customer, List<Product> products)
    {
        
        _products = products;
        _customer= customer;
        
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string Calculations()
    {
        _totalPrice = 0;
        foreach (Product product in _products)
        {
            _totalPrice += product.TotalPrice();
        }
        _totalPrice += _customer.ShippingCost();
        return $"Total Price: {_totalPrice}";
    }
     public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += product.GetPackingLabel() + "\n";
    
        }
        return $"Packing Label: \n{label}";
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetShippingLabel()}";   
    }
}