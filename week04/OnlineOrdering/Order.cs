using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        int shippingCost = _customer.IsInUSA() ? 5 : 35;
        
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "--- PACKING LABEL ---\n";
        foreach (Product p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- SHIPPING LABEL ---\n";
        label += $"{_customer.GetName()}\n";
        label += $"{_customer.GetAddress().GetFullAddress()}\n";
        return label;
    }
}