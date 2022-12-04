namespace OpenClosedPrinciple.Lib;

public class University
{
    public Student Student { get; set; }
    public Teacher Teacher { get; set; }

    public void Print()
    {
        Student.Print();
        Teacher.Print();
    }
}