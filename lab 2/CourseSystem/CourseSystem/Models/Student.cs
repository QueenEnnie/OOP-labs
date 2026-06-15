namespace CourseSystem.Models;

public class Student : IPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
