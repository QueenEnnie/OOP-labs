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
    
    public void AddCourse(int courseId, string courseTitle, string courseType, List<Student> students)
    {
        Course course = null;
        if (courseType == "1")
        {
            course = new OnlineCourse(courseId, courseTitle, students);
        }
        else if (courseType == "2")
        {
            course = new OfflineCourse(courseId, courseTitle, students);
        }
        _courses.Add(courseId, course);
    }

    public void AddTeacher(int teacherId, string teacherName)
    {
        Teacher teacher = new Teacher(teacherId, teacherName);
        _teachers.Add(teacherId, teacher);
    }
    
    public void DeleteCourse(int courseId)
    {
        _courses.Remove(courseId);
    }

    public List<String> GetAllCourses()
    {
        List<string> coursesInformation = new List<string>();
        foreach (KeyValuePair<int, Course> course in _courses)
        {

            coursesInformation.Add($"\"{course.Value.CourseTitle}\" (id {course.Key}) {course.Value.CourseType}");
        }
        return coursesInformation;
    }

    public void AppointTeacher(int teacherId, int courseId)
    {
        _courses[courseId].AppointTeacher(teacherId);
        _teachers[teacherId].AddToCourse(_courses[courseId]);
        
    }

    public List<string> GetAllTeacherCourses(int teacherId)
    {
        List<string> coursesInformationForTeacher = new List<string>();
        foreach (Course course in _teachers[teacherId].Courses)
        {
            coursesInformationForTeacher.Add($"\"{course.CourseTitle}\" (id {course.CourseId}) {course.CourseType}");
        }
        return coursesInformationForTeacher;
    }

    public List<String> GetAllStudentsInCourse(int courseId)
    {
        List<string> studentsInformation = new List<string>();
        foreach (Student student in _courses[courseId].Students)
        {
            studentsInformation.Add($"{student.Name} (id {student.Id})");
        }
        return studentsInformation;
    }

    public List<String> GetAllTeachers()
    {
        List<string> teachersInformation = new List<string>();
        foreach (Teacher teacher in  _teachers.Values)
        {
            teachersInformation.Add($"{teacher.Name} (id {teacher.Id})");
        }
        return teachersInformation;
    }

    public bool IsCourseExisted(int courseId)
    {
        return _courses.ContainsKey(courseId);
    }

    public bool IsTeacherExisted(int teacherId)
    {
        return _teachers.ContainsKey(teacherId);
    }
}