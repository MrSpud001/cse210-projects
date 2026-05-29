class Order
{
    private List<Product> _productsList = [];
    private Customer _customer;


    public Order(List<Product> products, Customer customer)
    {
        _productsList = products;
        _customer = customer;
    }

    public double TotalPrice()
    {
        double total = 0; 
        foreach(Product product in _productsList)
        {
            total += product.TotalPrice();
        }

        if (CalcShipping())
        {
            return total += 5;
        }

        return total += 35;
    }

    public bool CalcShipping()
    {
        return _customer.CustomerInUSA();
    }


    public string PackingLabel()
    {
        string label = "";
        foreach(Product product in _productsList)
        {
            label += product.ProductLabel();
        }

        return label;
    }

    public string ShippingLabel()
    {
        return $"Name: {_customer.GetName()}, Address: {_customer.GetAddress()}";
    }



}