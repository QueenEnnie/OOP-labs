namespace CourseSystem.Models;

public class OnlineCourse : Course
{
    public OnlineCourse(int courseId,  string courseTitle, List<Student> students)
    {
        CourseId = courseId;
        CourseTitle = courseTitle;
        Students = students;
        CourseType = "онлайн";
    }

    public int CourseId { get; }
    public string CourseTitle { get; }
    public int TeacherId { get; set; }
    public string CourseType { get; }
    public List<Student> Students { get; }

    public void AppointTeacher(int teacherId)
    {
        TeacherId = teacherId;
        Console.WriteLine($"Teacher ID: {TeacherId}");
    }

    public override string ToString()
    {
        return $"{CourseTitle} - {CourseId}";
    }
    
}