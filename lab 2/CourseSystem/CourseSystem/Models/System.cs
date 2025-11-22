using CourseSystem.Models;

namespace CourseSystem.Models;

public class ManagementSystem
{
    private List<Course> _courses;
    private List<Teacher> _teachers;

    // public ManagementSystem(List<Course> courses)
    // {
    //     _courses = courses;
    // }
    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }

    public void DeleteCourse(Course course)
    {
        
    }

    public void AddTeacher(Teacher teacher)
    {
        
    }
    
}