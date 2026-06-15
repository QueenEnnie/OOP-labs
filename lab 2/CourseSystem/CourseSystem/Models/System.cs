namespace CourseSystem.Models;

public class ManagementSystem
{
    private readonly Dictionary<int, ICourse> _courses;
    private readonly Dictionary<int, Teacher> _teachers;

    public ManagementSystem()
    {
        _courses = new Dictionary<int, ICourse>();
        _teachers = new Dictionary<int, Teacher>();
    }
    
    public void AddCourse(int courseId, string courseTitle, string courseType, List<Student> students)
    {
        AddCourse(courseId, courseTitle, ParseCourseKind(courseType), students);
    }

    public void AddCourse(int courseId, string courseTitle, CourseKind courseKind, List<Student> students)
    {
        if (_courses.ContainsKey(courseId))
        {
            throw new ArgumentException("Course with this id already exists.", nameof(courseId));
        }
        if (string.IsNullOrWhiteSpace(courseTitle))
        {
            throw new ArgumentException("Course title cannot be empty.", nameof(courseTitle));
        }

        ICourse course = courseKind switch
        {
            CourseKind.Online => new OnlineCourse(courseId, courseTitle, students),
            CourseKind.Offline => new OfflineCourse(courseId, courseTitle, students),
            _ => throw new ArgumentOutOfRangeException(nameof(courseKind), courseKind, "Unknown course kind.")
        };

        _courses.Add(courseId, course);
    }

    public void AddTeacher(int teacherId, string teacherName)
    {
        if (_teachers.ContainsKey(teacherId))
        {
            throw new ArgumentException("Teacher with this id already exists.", nameof(teacherId));
        }
        if (string.IsNullOrWhiteSpace(teacherName))
        {
            throw new ArgumentException("Teacher name cannot be empty.", nameof(teacherName));
        }

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
        foreach (KeyValuePair<int, ICourse> course in _courses)
        {

            coursesInformation.Add($"\"{course.Value.CourseTitle}\" (id {course.Key}) {course.Value.CourseType}");
        }
        return coursesInformation;
    }

    public void AppointTeacher(int teacherId, int courseId)
    {
        if (!_courses.ContainsKey(courseId))
        {
            throw new KeyNotFoundException($"Course with id {courseId} does not exist.");
        }
        if (!_teachers.ContainsKey(teacherId))
        {
            throw new KeyNotFoundException($"Teacher with id {teacherId} does not exist.");
        }

        _courses[courseId].AppointTeacher(teacherId);
        _teachers[teacherId].AddToCourse(_courses[courseId]);
    }

    public List<string> GetAllTeacherCourses(int teacherId)
    {
        List<string> coursesInformationForTeacher = new List<string>();
        foreach (ICourse course in _teachers[teacherId].Courses)
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

    private static CourseKind ParseCourseKind(string courseType)
    {
        return courseType switch
        {
            "1" => CourseKind.Online,
            "2" => CourseKind.Offline,
            _ => throw new ArgumentException("Unknown course type.", nameof(courseType))
        };
    }
}
