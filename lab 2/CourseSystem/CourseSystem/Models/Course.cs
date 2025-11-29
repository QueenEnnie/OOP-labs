namespace CourseSystem.Models;

public interface Course
{
    int CourseId {get;}
    string CourseTitle {get;}
    int TeacherId {get;}
    string CourseType {get;}
    List<Student> Students { get; }
    void AppointTeacher(int teacherId);
}




