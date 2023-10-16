namespace Exercise1;

/// <summary>
/// Represents a customer.
/// </summary>
public class Customer : Person
{
    /// <summary>
    /// The purchases of the customer.
    /// </summary>
    public List<Sale> Purchases { get; set; } = new();

    /// <summary>
    /// Creates a new instance of the <see cref="Customer"/> class.
    /// </summary>
    /// <param name="firstName">The first name of the customer.</param>
    /// <param name="lastName">The last name of the customer.</param>
    /// <param name="age">The age of the customer.</param>
    public Customer(string firstName, string lastName, int age)
        : base(firstName, lastName, age)
    {
    }
    
    /// <summary>
    /// Prints the purchases of the customer.
    /// </summary>
    public void PrintPurchases()
    {
        Console.WriteLine($"Purchases for {this}\n");
        foreach (var purchase in Purchases)
        {
            Console.WriteLine(purchase);
        }

        Console.WriteLine("---------------------------------\n");
    }
    
    /// <summary>
    /// Returns a string representation of the <see cref="Customer"/> class.
    /// </summary>
    /// <returns>
    /// A string representation of the <see cref="Customer"/> class.
    /// </returns>
    public override string ToString()
    {
        return $"Customer: {base.ToString()}";
    }
}