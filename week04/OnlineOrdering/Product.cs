class Product
{
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _productID = id;
        _productPrice = price;
        _quantity = quantity;
    }

    public double TotalPrice()
    {
        return _productPrice * _quantity;
    }

    public string ProductLabel()
    {
        return $"Product Name: {_productName}, ID: {_productID}\n";
    }

}