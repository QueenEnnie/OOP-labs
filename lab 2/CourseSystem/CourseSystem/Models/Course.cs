namespace CourseSystem.Models;

public interface Course
{
    int CourseID {get;}
    string CourseTitle {get;}
    int TeacherId {get;}
    List<Student> Students { get; }
    void AppointTeacher(int teacherId);
}




