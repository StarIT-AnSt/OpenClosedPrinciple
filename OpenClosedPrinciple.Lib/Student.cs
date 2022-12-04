namespace OpenClosedPrinciple.Lib;

public class Student : Person
{
    public string Faculty { get; set; }
    
    public override void Print()
    {
        Console.WriteLine($"{LastName} {FirstName}, {Age}, {Faculty}");
    }
}