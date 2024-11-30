public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsUsa()
    {
        if (_country.ToLower() == "usa" || _country.ToLower() == "united states" || _country.ToLower() == "united states of america")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string ReturnAddress()
    {
        return $"{_streetAddress} \n{_city}, {_stateOrProvince} \n{_country}";
    }
}