namespace CourseSystem.Models;

public class Student : Person
{
    public int Id { get; }
    public string Name { get; }
    public string Email { get; }
    public string Group { get; }
    public void AddToCourse(Course course)
    {
        throw new NotImplementedException();
    }
}