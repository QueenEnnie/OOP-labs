using CourseSystem.Models;

namespace CourseSystem
{
    class Program
        {
            private static ManagementSystem _system = new();
            static void ManageCourses()
            {
                Console.WriteLine(ConsoleMessages.ManageCourseMenu.AllMessage);
                var userChoice = Console.ReadLine();
                while (userChoice != "end")
                {
                    switch (userChoice)
                    {  
                        case "1":
                            AddCourse();
                            break;
                        case "2":
                            RemoveCourse();
                            break;
                        case "3":
                            GetAllCourses();
                            break;
                        case "4":
                            GetAllStudentsInCourse();
                            break;
                        default: 
                            Console.WriteLine(ConsoleMessages.ManageCourseMenu.UnknownOperation);
                            break;
                    }
                    Console.WriteLine(ConsoleMessages.ManageCourseMenu.AllMessage);
                    userChoice = Console.ReadLine();
                }
            }

            static int GetId()
            {
                string input = Console.ReadLine();
                int id;
                while (!int.TryParse(input, out id))
                {
                    Console.WriteLine(ConsoleMessages.ManageCourseMenu.IdMistake);
                    input = Console.ReadLine();
                }  
                return id;
            }

            static int GetTeacherId()
            {
                int teacherId = GetId();
                while (!_system.IsTeacherExisted(teacherId))
                {
                    Console.WriteLine(ConsoleMessages.ManageTeachersMenu.TeacherNotExisted);
                    teacherId = GetId();
                }
                return teacherId;
            }
            
            static string GetTitle()
            {
                Console.WriteLine(ConsoleMessages.ManageCourseMenu.TitleInput);
                string courseTitle = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(courseTitle))
                {
                    Console.WriteLine(ConsoleMessages.ManageCourseMenu.EmptyTitle);
                    courseTitle = Console.ReadLine();
                }
                return courseTitle;
            }

            static string GetCourseType()
            {
                Console.WriteLine(ConsoleMessages.ManageCourseMenu.TypeOfCourseChoice);
                string courseType = Console.ReadLine();
                while (!(courseType == "1" || courseType == "2"))
                {
                    Console.WriteLine(ConsoleMessages.ManageCourseMenu.IncorrectTypeChoice);
                    courseType = Console.ReadLine();
                }
                return courseType;
            }
            
            static void AddCourse()
            {
                Console.WriteLine(ConsoleMessages.ManageCourseMenu.IdInput);
                
                int courseId = GetId();
                while (_system.IsCourseExisted(courseId))
                {
                    Console.WriteLine(ConsoleMessages.ManageCourseMenu.IdAlreadyExisting);
                    courseId = GetId();
                }
                string courseTitle = GetTitle();
                string courseType = GetCourseType();
                List<Student> emptyStudents = new List<Student>();

                _system.AddCourse(courseId, courseTitle, courseType, emptyStudents);
                Console.WriteLine(ConsoleMessages.ManageCourseMenu.SuccessfulCreation);
            }

            static void RemoveCourse()
            {
                Console.WriteLine(ConsoleMessages.ManageCourseMenu.IdInputToDelete);
                int courseId = GetId();
                while (!_system.IsCourseExisted(courseId))
                {
                    Console.WriteLine(ConsoleMessages.ManageCourseMenu.CourseNotExisted);
                    courseId = GetId();
                }
                _system.DeleteCourse(courseId);
                Console.WriteLine(ConsoleMessages.ManageCourseMenu.SuccessfulDeletion);
            }

            static void GetAllCourses()
            {
                Console.WriteLine(ConsoleMessages.ManageCourseMenu.AllCourses);
                foreach (string text in _system.GetAllCourses())
                {
                    Console.WriteLine(text);
                }
            }

            static void GetAllStudentsInCourse()
            {
                Console.WriteLine(ConsoleMessages.ManageCourseMenu.IdCourseToGetStudents);
                int courseId = GetId();
                while (!_system.IsCourseExisted(courseId))
                {
                    Console.WriteLine(ConsoleMessages.ManageCourseMenu.CourseNotExisted);
                    courseId = GetId();
                }
                foreach (string text in _system.GetAllStudentsInCourse(courseId))
                {
                    Console.WriteLine(text);
                }
            }
            static void ManageTeachers()
            {
                Console.WriteLine(ConsoleMessages.ManageTeachersMenu.AllMessage);
                var userChoice = Console.ReadLine();
                while (userChoice != "end")
                {
                    switch (userChoice)
                    {  
                        case "1":
                            AppointTeacher();
                            break;
                        case "2":
                            GetAlLCoursesByOneTeacher();
                            break;
                        default: 
                            Console.WriteLine(ConsoleMessages.ManageCourseMenu.UnknownOperation);
                            break;
                    }
                    Console.WriteLine(ConsoleMessages.ManageTeachersMenu.AllMessage);
                    userChoice = Console.ReadLine();
                }   
            }

            static void AppointTeacher()
            {
                Console.WriteLine(ConsoleMessages.ManageTeachersMenu.IdCourseInput);
                int courseId = GetId();
                while (!_system.IsCourseExisted(courseId))
                {
                    Console.WriteLine(ConsoleMessages.ManageCourseMenu.CourseNotExisted);
                    courseId = GetId();
                }
                
                Console.WriteLine(ConsoleMessages.ManageTeachersMenu.ListOfTeachers);
                foreach (string text in _system.GetAllTeachers())
                {
                    Console.WriteLine(text);
                }
                Console.WriteLine(ConsoleMessages.ManageTeachersMenu.IdTeacherInput);

                int teacherId = GetTeacherId();
                _system.AppointTeacher(teacherId, courseId);
                Console.WriteLine(ConsoleMessages.ManageTeachersMenu.SuccessfulAppointment);
            }

            static void GetAlLCoursesByOneTeacher()
            {
                Console.WriteLine(ConsoleMessages.ManageTeachersMenu.IdTeacherInputToGetCourse);
                int teacherId = GetTeacherId();
                foreach (string text in _system.GetAllTeacherCourses(teacherId))
                {
                    Console.WriteLine(text);
                }
            }

            static void FillTheSystem()
            {
                List<Student> students = new List<Student>
                {
                    new Student(1, "Иванов Иван"),
                    new Student(2, "Петров Петр"),
                    new Student(3, "Сидорова Мария"),
                    new Student(4, "Кузнецов Алексей"),
                    new Student(5, "Николаева Анна")
                };
                _system.AddTeacher(123, "Alice");
                _system.AddTeacher(124, "Alexander");
                _system.AddCourse(13, "maths", "2", students);
                _system.AddCourse(24, "english", "2", students);
                
            }
            static void Main(string[] args)
            {
                FillTheSystem();
                Console.WriteLine(ConsoleMessages.MainMenu.AllMessage);
                var userChoice = Console.ReadLine();
                while (userChoice != "end")
                {
                    switch (userChoice)
                    {  
                        case "1":
                            ManageCourses();
                            break;
                        case "2":
                            ManageTeachers();
                            break;
                        default: 
                            Console.WriteLine(ConsoleMessages.MainMenu.UnknownOperation);
                            break;
                    }
                    Console.WriteLine(ConsoleMessages.MainMenu.AllMessage);
                    userChoice = Console.ReadLine();
                }

            }
        }
}