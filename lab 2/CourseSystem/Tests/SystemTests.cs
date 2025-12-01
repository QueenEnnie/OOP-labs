using CourseSystem.Models;

namespace Tests;

public class SystemTests
{
    [Fact]
    public void AddCourse_OnlineCourse_ShouldAddToSystem()
    {
        var system = new ManagementSystem();
        var students = new List<Student> { new Student(1, "Alice") };
        system.AddCourse(101, "C++", "1", students);
        
        Assert.True(system.IsCourseExisted(101));
        var courses = system.GetAllCourses();
        Assert.Single(courses);
        Assert.Contains("\"C++\" (id 101) онлайн", courses);
    }
    
    [Fact]
    public void AddTeacher_ShouldAddToSystem()
    {
        var system = new ManagementSystem();
        var students = new List<Student> { new Student(1, "Alice") };
        system.AddCourse(101, "C++", "1", students);
        system.DeleteCourse(101);
        
        Assert.False(system.IsCourseExisted(101));
        var courses = system.GetAllCourses();
        Assert.Empty(courses);
    }
    
    [Fact]
    public void DeleteCourse_ShouldRemoveCourseFromSystem()
    {
        var system = new ManagementSystem();
        system.AddTeacher(13, "Cruella");
        
        Assert.True(system.IsTeacherExisted(13));
        var teachers = system.GetAllTeachers();
        Assert.Single(teachers);
        Assert.Contains($"Cruella (id 13)", teachers);
    }
    [Fact]
    public void GetAllCourses_ShouldReturnCourseList()
    {
        var system = new ManagementSystem();
        var onlineStudents = new List<Student> { new Student(1, "Anna") };
        system.AddCourse(91, "TPV", "1", onlineStudents);
        var offlineStudents = new List<Student> { new Student(2, "ann") };
        system.AddCourse(176, "Informatics", "2", offlineStudents);
        var courses = system.GetAllCourses();

        Assert.Equal(2, courses.Count);
        Assert.Contains("\"TPV\" (id 91) онлайн", courses);
        Assert.Contains("\"Informatics\" (id 176) оффлайн", courses);
    }
    
    [Fact]
    public void AppointTeacher_ShouldAddCourseToTeacher()
    {
        var system = new ManagementSystem();
        var students = new List<Student> { new Student(1, "Anna") };
        system.AddCourse(18, "Spanish", "2",students);
        system.AddTeacher(4, "George");
        system.AppointTeacher(4, 18);

        var teacherCourses = system.GetAllTeacherCourses(4);
        Assert.Contains("\"Spanish\" (id 18) оффлайн", teacherCourses);
    }
    
    [Fact]
    public void GetAllTeacherCourses_ShouldReturnCoursesList()
    {
        var system = new ManagementSystem();
        var students = new List<Student>
        {
            new Student(1, "Alice"),
            new Student(28, "Boris")
        };
        system.AddCourse(101, "Italian", "1", students);
        system.AddTeacher(1, "Smith");
        system.AppointTeacher(1, 101);
        var courses = system.GetAllTeacherCourses(1);

        Assert.Single(courses);
        Assert.Contains("\"Italian\" (id 101) онлайн", courses);
    }
    
    [Fact]
    public void GetAllStudentsInCourse_ShouldReturnStudentList()
    {
        var system = new ManagementSystem();
        var students = new List<Student>
        {
            new Student(1, "Alice"),
            new Student(28, "Boris")
        };
        system.AddCourse(101, "Italian", "1", students);
        var studentList = system.GetAllStudentsInCourse(101);

        Assert.Equal(2, studentList.Count);
        Assert.Contains("Alice (id 1)", studentList);
        Assert.Contains("Boris (id 28)", studentList);
    }
    
    [Fact]
    public void GetAllTeachers_ShouldReturnTeacherList()
    {
        var system = new ManagementSystem();
        system.AddTeacher(1, "Alexander");
        system.AddTeacher(2, "Pavlova");
        var teachers = system.GetAllTeachers();

        Assert.Equal(2, teachers.Count);
        Assert.Contains("Alexander (id 1)", teachers);
        Assert.Contains("Pavlova (id 2)", teachers);
    }
}