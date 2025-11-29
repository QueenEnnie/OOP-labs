namespace CourseSystem.Models;

public class Teacher : Person
{
    public int Id { get; }
    public string Name { get; }
    public List<Course> Courses { get; }

    public Teacher(int id, string name)
    {
        Id = id;
        Name = name;
        Courses = new List<Course>(); 
    }
    public void AddToCourse(Course course)
    {
        Courses.Add(course);
    }
}