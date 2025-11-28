namespace CourseSystem.Models;

public class Student : Person
{
    public int Id { get; }
    public string Name { get; }
    public string Email { get; }
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

}