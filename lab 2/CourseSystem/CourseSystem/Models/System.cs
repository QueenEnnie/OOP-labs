using CourseSystem.Models;

namespace CourseSystem.Models;

public class ManagementSystem
{
    private Dictionary<int, Course> _courses;
    private Dictionary<int, Teacher> _teachers;

    public ManagementSystem()
    {
        _courses = new Dictionary<int, Course>();
        _teachers = new Dictionary<int, Teacher>();
    }
    
    public void AddCourse(int courseId, string courseTitle, string courseType, )
    {
        Course course = null;
        if (courseType == "1")
        {
            course = new OnlineCourse(courseId, courseTitle);
        }
        else if (courseType == "2")
        {
            course = new OfflineCourse(courseId, courseTitle);
        }
        _courses.Add(courseId, course);
        string courseTypeWords = (courseType == "1") ? "Онлайн" : "Оффлайн";
        Console.WriteLine($"{courseTypeWords} курс с id {course.CourseID} и названием {courseTitle} " +
                          $"был успешно создан!");
    }

    public void AddTeacher(int teacherId, string teacherName)
    {
        Teacher teacher = new Teacher(teacherId, teacherName);
        _teachers.Add(teacherId, teacher);
    }
    
    public void DeleteCourse(int courseId)
    {
        _courses.Remove(courseId);
        Console.WriteLine($"Курс с id {courseId} был удален!");
    }

    public void GetAllCourses()
    {
        foreach (KeyValuePair<int, Course> course in _courses)
        {
            // change when description and teachers will be added - to print them and type of the course
            Console.WriteLine($"\"{course.Value.CourseTitle}\" (id {course.Key})");
        }
    }

    public void AppointTeacher(int teacherId, int courseId)
    {
        _courses[courseId].AppointTeacher(teacherId);
        _teachers[teacherId].AddToCourse(_courses[courseId]);
        
    }

    public void GetAllTeacherCourses(int teacherId)
    {
        foreach (Course course in _teachers[teacherId].Courses)
        {
            Console.WriteLine(course);
        }
        
    }
    
}