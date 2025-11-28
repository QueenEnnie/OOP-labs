namespace CourseSystem.Models;

public class OfflineCourse : Course
{
    public OfflineCourse(int courseId, string courseTitle, List<Student> students)
    {
        CourseID = courseId;
        CourseTitle = courseTitle;
        Students = students;
    }

    public int CourseID { get; }
    public string CourseTitle { get; }
    public int TeacherId { get; set; }
    public List<Student> Students { get; }

    public void AppointTeacher(int teacherId)
    {
        TeacherId = teacherId;
    }

    public override string ToString()
    {
        return $"{CourseTitle} - {CourseID}";
    }
}
