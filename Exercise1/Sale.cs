namespace Exercise1;

/// <summary>
/// Represents a sale.
/// </summary>
public class Sale
{
    /// <summary>
    /// The name of the product.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The price of the product.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// The customer who bought the product.
    /// </summary>
    public Customer Customer { get; set; }

    /// <summary>
    /// The employee who sold the product.
    /// </summary>
    public Employee Employee { get; set; }

    /// <summary>
    /// The date of the sale in UTC.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Creates a new instance of the <see cref="Sale"/> class.
    /// </summary>
    /// <param name="name">The name of the product.</param>
    /// <param name="price">The price of the product.</param>
    /// <param name="customer">The customer who bought the product.</param>
    /// <param name="employee">The employee who sold the product.</param>
    public Sale(string name, decimal price, Customer customer, Employee employee)
    {
        Name = name;
        Price = price;
        Customer = customer;
        Employee = employee;
        Date = DateTime.UtcNow;
        
        RegisterSale();
    }
    
    /// <summary>
    /// Creates a new instance of the <see cref="Sale"/> class.
    /// </summary>
    /// <param name="name">The name of the product.</param>
    /// <param name="price">The price of the product.</param>
    /// <param name="customer">The customer who bought the product.</param>
    /// <param name="employee">The employee who sold the product.</param>
    /// <param name="date">The date of the sale in UTC.</param>
    public Sale(string name, decimal price, Customer customer, Employee employee, DateTime date)
    {
        Name = name;
        Price = price;
        Customer = customer;
        Employee = employee;
        Date = date;
        
        RegisterSale();
    }

    /// <summary>
    /// Registers the sale to the customer and employee.
    /// </summary>
    private void RegisterSale()
    {
        Customer.Purchases.Add(this);
        Employee.Sales.Add(this);
    }

    /// <summary>
    /// Returns a string representation of the <see cref="Sale"/> class.
    /// </summary>
    /// <returns>
    /// A string representation of the <see cref="Sale"/> class.
    /// </returns>
    public override string ToString()
    {
        return $"Sale: {Name}, {Price:C}, {Customer}, {Employee}, {Date.ToLocalTime()}"; // The date is in UTC
    }
}