namespace CourseSystem.Models;

public class Teacher : IPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ICourse> Courses { get; }

    public Teacher(int id, string name)
    {
        Id = id;
        Name = name;
        Courses = new List<ICourse>(); 
    }
    public void AddToCourse(ICourse course)
    {
        Courses.Add(course);
    }
}
