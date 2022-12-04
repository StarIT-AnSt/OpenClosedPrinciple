using OpenClosedPrinciple.Lib;

Student student1 = new Student
{
    FirstName = "A",
    LastName = "B",
    Age = 3,
    Faculty = "F"
};

Person student2 = new Student
{
    FirstName = "A",
    LastName = "B",
    Age = 3,
    Faculty = "F"
};

Teacher teacher1 = new Teacher()
{
    FirstName = "A",
    LastName = "B",
    Age = 3,
    Department = "D"
};

Person teacher2 = new Teacher()
{
    FirstName = "A",
    LastName = "B",
    Age = 3,
    Department = "D"
};

student1.Print();
//((Student)student2).Print();
student2.Print();

teacher1.Print();
teacher2.Print();
