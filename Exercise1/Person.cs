namespace Exercise1;

/// <summary>
/// Represents a person.
/// </summary>
public class Person
{
    /// <summary>
    /// The number of instances created of the <see cref="Person"/> class.
    /// </summary>
    public static int InstanceCount { get; private set; }

    /// <summary>
    /// The first name of the person.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// The last name of the person.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// The age of the person.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Creates a new instance of the <see cref="Person"/> class.
    /// </summary>
    /// <param name="firstName">The first name of the person.</param>
    /// <param name="lastName">The last name of the person.</param>
    /// <param name="age">The age of the person.</param>
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;

        IncrementInstanceCount();
    }

    /// <summary>
    /// Increments the number of instances of the Person class.
    /// </summary>
    private static void IncrementInstanceCount()
    {
        InstanceCount++;
    }

    /// <summary>
    /// Prints a message to the console with the person's name.
    /// </summary>
    public void Speak()
    {
        Console.WriteLine($"Hello my name is {FirstName} {LastName}.");
    }


    /// <summary>
    /// Returns a string representation of the <see cref="Person"/> class.
    /// </summary>
    /// <returns>
    /// A string representation of the <see cref="Person"/> class.
    /// </returns>
    public override string ToString()
    {
        return $"{FirstName} {LastName}, {Age}";
    }
}