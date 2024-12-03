using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(string name, string streetAddress, string city, string stateOrProvince, string country)
    {
        _products = new List<Product>();
        
        _customer = new Customer(name, streetAddress, city, stateOrProvince, country);
    }

    public void AddProduct(string name, string id, double price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _products.Add(product);
    }

    public double CalculateCost()
    {
        double totalCost = 0;
        double shippingCost;

        foreach (Product product in _products)
        {
            totalCost += product.CalculateProductPrice();
        }

        if (_customer.IsUsa())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return Math.Round(totalCost + shippingCost, 2);
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.ReturnProductInfo());
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.ReturnCustomerInfo());
    }
}