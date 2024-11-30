using System.Reflection.Metadata.Ecma335;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string streetAddress, string city, string stateOrProvince, string country)
    {
        _name = name;
        _address = new Address(streetAddress, city, stateOrProvince, country);
    }

    public bool IsUsa()
    {
        return _address.IsUsa();
    }

    public string ReturnCustomerInfo()
    {
        return $"{_name} \n{_address.ReturnAddress()}";
    }
}