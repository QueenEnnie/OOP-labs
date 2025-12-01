using CourseSystem.Models;

namespace Tests;

public class TeacherTest
{
    [Fact]
    public void AddToCourse_ShouldAddToCourse()
    {
        List<Student> students = new List<Student>
        {
            new Student(1, "Andrew"),
            new Student(2, "Alex"),
        };
        var course = new OfflineCourse(390, "OOP", students);
        var teacher = new Teacher(89, "Anton");
        teacher.AddToCourse(course);
        Assert.Single(teacher.Courses);
        Assert.Contains(course, teacher.Courses);
    }

}