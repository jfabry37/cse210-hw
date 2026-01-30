public class Product
{
    private string _productName;
    private string _id;
    private decimal _price;
    private int _quantity;
    public Product(string productName, string id, decimal price, int quantity)
        {
            _productName = productName;
            _id = id;
            _price = price;
            _quantity = quantity;
        }
    public decimal TotalPrice()
    {
        return _price * _quantity;
    }
    public string GetPackingLabel()
    {
        return $"{_productName}  ID: {_id}";
    }

}