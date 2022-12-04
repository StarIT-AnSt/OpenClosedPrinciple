namespace OpenClosedPrinciple.Lib;

public class Teacher : Person
{
    public string Department { get; set; }

    public override void Print()
    {
        Console.WriteLine($"{LastName} {FirstName}, {Age}, {Department}");
    }
}