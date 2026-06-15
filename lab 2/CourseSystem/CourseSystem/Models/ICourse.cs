namespace CourseSystem.Models;

public interface ICourse
{
    int CourseId {get;}
    string CourseTitle {get;}
    int TeacherId {get; set; }
    string CourseType {get;}
    List<Student> Students { get; }
    void AppointTeacher(int teacherId);
}




