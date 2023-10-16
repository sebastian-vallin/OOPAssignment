namespace Exercise1;

public class Employee : Person
{
    /// <summary>
    /// The sales of the employee.
    /// </summary>
    public List<Sale> Sales { get; set; } = new();

    public decimal Salary { get; set; }

    /// <summary>
    /// Creates a new instance of the <see cref="Employee"/> class.
    /// </summary>
    /// <param name="firstName">The first name of the employee.</param>
    /// <param name="lastName">The last name of the employee.</param>
    /// <param name="age">The age of the employee.</param>
    /// <param name="salary">The salary of the employee.</param>
    public Employee(string firstName, string lastName, int age, decimal salary)
        : base(firstName, lastName, age)
    {
        Salary = salary;
    }

    /// <summary>
    /// Computes the number of sales.
    /// </summary>
    /// <returns>The number of sales.</returns>
    public int GetNumberOfSales()
    {
        return Sales.Count;
    }

    /// <summary>
    /// Computes the total price of the sales.
    /// </summary>
    /// <returns>The total price of the sales</returns>
    public decimal GetSalesTotal()
    {
        return Sales.Sum(s => s.Price);
    }

    /// <summary>
    /// Computes the average price of the sales.
    /// </summary>
    /// <returns>The average price of the sales.</returns>
    public decimal GetSalesAverage()
    {
        return Sales.Average(s => s.Price);
    }

    /// <summary>
    /// Prints the statistics of the employee.
    /// </summary>
    public void PrintStatistics()
    {
        Console.WriteLine($"Statistics for {this}\n");
        Console.WriteLine($"Number of sales: {GetNumberOfSales()}");
        Console.WriteLine($"Total value of sales: {GetSalesTotal():C}");
        Console.WriteLine($"Average value of sales: {GetSalesAverage():C}");
        Console.WriteLine("---------------------------------\n");
    }

    /// <summary>
    /// Prints the sales of the employee.
    /// </summary>
    public void PrintSales()
    {
        Console.WriteLine($"Sales for {this}\n");
        foreach (var sale in Sales)
        {
            Console.WriteLine(sale);
        }

        Console.WriteLine("---------------------------------\n");
    }

    /// <summary>
    /// Returns a string representation of the <see cref="Employee"/> class.
    /// </summary>
    /// <returns>
    /// A string representation of the <see cref="Employee"/> class.
    /// </returns>
    public override string ToString()
    {
        return
            $"Employee: {base.ToString()}, Salary {Salary:C}"; // C is for currency - equivalent to {Salary.ToString("C")}
    }
}