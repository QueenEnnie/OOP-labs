namespace CourseSystem.Models;

public interface Person
{
    int Id { get; }
    string Name { get; }
    string Email { get; }
    void AddToCourse(Course course);
}