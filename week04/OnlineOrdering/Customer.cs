class Customer
{
    private string _customerName;
    private Address _customerAddress;


    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }


    public bool CustomerInUSA()
    {
        return _customerAddress.IsFromUSA();
    }

    public string GetAddress()
    {
        return _customerAddress.AddressFormatted();
    }

    public string GetName()
    {
        return _customerName;
    }

}