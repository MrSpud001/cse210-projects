class Address
{
    private string _addressStreet;
    private string _addressCity;
    private string _addressStateProvince;
    private string _addressCountry;


    public Address(string street, string city, string state, string country)
    {
        _addressStreet = street;
        _addressCity = city;
        _addressStateProvince = state;
        _addressCountry = country;
    }


    public bool IsFromUSA()
    {
        return _addressCountry == "USA";
    }

    public string AddressFormatted()
    {
        return $"{_addressStreet}, {_addressCity}\n{_addressStateProvince}, {_addressCountry}";
    }
}