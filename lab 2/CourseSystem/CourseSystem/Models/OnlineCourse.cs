namespace CourseSystem.Models;

public class OnlineCourse : Course
{
    public OnlineCourse(int courseId,  string courseTitle)
    {
        CourseID = courseId;
        CourseTitle = courseTitle;
        Students = new List<Student>();
    }

    public int CourseID { get; }
    public string CourseTitle { get; }
    public int TeacherId { get; set; }
    public List<Student> Students { get; }

    public void AppointTeacher(int teacherId)
    {
        TeacherId = teacherId;
        Console.WriteLine($"Teacher ID: {TeacherId}");
    }

    public override string ToString()
    {
        return $"{CourseTitle} - {CourseID}";
    }
    
}