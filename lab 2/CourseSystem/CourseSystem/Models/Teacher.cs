namespace CourseSystem.Models;

public class Teacher : Person
{
    public int Id { get; }
    public string Name { get; }
    public string Email { get; }
    public string Role { get; }
    public void AddToCourse(Course course)
    {
        throw new NotImplementedException();
    }
}