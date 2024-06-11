using System.Collections.Generic;

public class Order
{
    private List<Product> Products { get; set; } = new List<Product>();
    private Customer Customer { get; set; }
    private const double ShippingCostUSA = 5.0;
    private const double ShippingCostInternational = 35.0;

    public Order(Customer customer)
    {
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in Products)
        {
            total += product.GetTotalCost();
        }
        total += Customer.IsInUSA() ? ShippingCostUSA : ShippingCostInternational;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (Product product in Products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping To:\n{Customer.Name}\n{Customer.Address.GetFullAddress()}";
    }
}
