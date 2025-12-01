using CourseSystem.Models;

namespace Tests;

public class CourseTest
{
    [Fact]
    public void AppointTeacher_ShouldSetTeacherId()
    {
        List<Student> students = new List<Student>
        {
            new Student(1, "Andrew"),
            new Student(2, "Alex"),
        };
        var course = new OfflineCourse(18, "Spanish", students);
        var teacherId = 45;
        course.AppointTeacher(teacherId);
        Assert.Equal(teacherId, course.TeacherId);
    }

}