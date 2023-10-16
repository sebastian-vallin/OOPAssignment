using Exercise1;

// Create an instance of Person and call the Speak method.
var person = new Person("John", "Doe", 42);
person.Speak();

// Print the instance of Person.
Console.WriteLine(person);

// Create two instances of Customer and one instance of Employee.
var customer = new Customer("John", "Doe", 42);
var customer2 = new Customer("Jane", "Doe", 31);
var employee = new Employee("Emily", "Davis", 26, 350000);

// Print the instances of Customers and Employees.
Console.WriteLine(customer);
Console.WriteLine(customer2);
Console.WriteLine(employee);

// Print the number of instances of Person that has been created.
// The result will be 4, because we created 1 instance of Person, 2 instances of Customer and 1 instance of Employee.
// Customer and Employee both inherit from Person, thus they call the constructor of Person, which increments the InstanceCount.
Console.WriteLine($"Number of instances of Person: {Person.InstanceCount}");

Console.WriteLine();

// Use the static method PrintPerson to print the instances of Person, Customer and Employee.
Console.WriteLine("#### Using the static method PrintPerson ####");
PrintPerson(person);
PrintPerson(customer);
PrintPerson(customer2);
PrintPerson(employee);

Console.WriteLine();

// Create three instance of the Sale class.
var sale = new Sale("iPhone 15", 11_999, customer, employee);
var sale2 = new Sale("iPhone 15 Pro", 14_999, customer2, employee);
var sale3 = new Sale("AirPods Pro", 3_299, customer2, employee);

// Print the statistics of the employee.
employee.PrintStatistics();
employee.PrintSales();

// Print the purchases of the customers.
customer.PrintPurchases();
customer2.PrintPurchases();

// Prints the information of a person.
static void PrintPerson(Person person)
{
    Console.WriteLine(person);
}