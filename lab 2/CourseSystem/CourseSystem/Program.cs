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
                        default: 
                            Console.WriteLine(ConsoleMessages.ManageCourseMenu.UnknownOperation);
                            break;
                    }
                    userChoice = Console.ReadLine();
                }
            }

            static int GetId()
            {
                string input = Console.ReadLine();
                int id;
                
                while (!int.TryParse(input, out id))
                {
                    Console.WriteLine(ConsoleMessages.AddCourseMenu.IdMistake);
                    input = Console.ReadLine();
                }  
                return id;
            }
            
            static void AddCourse()
            {
                Console.WriteLine(ConsoleMessages.AddCourseMenu.IdInput);
                
                int courseId = GetId();
                
                Console.WriteLine(ConsoleMessages.AddCourseMenu.TitleInput);
                string courseTitle = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(courseTitle))
                {
                    Console.WriteLine(ConsoleMessages.AddCourseMenu.EmptyTitle);
                    courseTitle = Console.ReadLine();
                }
                
                Console.WriteLine(ConsoleMessages.AddCourseMenu.TypeOfCourseChoice);
                string courseType = Console.ReadLine();

                while (!(courseType == "1" || courseType == "2"))
                {
                    Console.WriteLine(ConsoleMessages.AddCourseMenu.IncorrectTypeChoice);
                    courseType = Console.ReadLine();
                }

                _system.AddCourse(courseId, courseTitle, courseType);
            }

            static void RemoveCourse()
            {
                Console.WriteLine(ConsoleMessages.RemoveCourseMenu.IdInput);
                int courseId = GetId();
                _system.DeleteCourse(courseId);
            }

            static void GetAllCourses()
            {
                Console.WriteLine(ConsoleMessages.GetCourseMenu.AllCourses);
                _system.GetAllCourses();
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
                    userChoice = Console.ReadLine();
                }   
            }

            static void AppointTeacher()
            {
                Console.WriteLine(ConsoleMessages.ManageTeachersMenu.IdCourseInput);
                int courseId = GetId();
                
                Console.WriteLine(ConsoleMessages.ManageTeachersMenu.ListOfTeachers);
                Console.WriteLine(ConsoleMessages.ManageTeachersMenu.Teachers);
                Console.WriteLine(ConsoleMessages.ManageTeachersMenu.IdTeacherInput);
                
                int teacherId = GetId();
                _system.AppointTeacher(teacherId, courseId);
            }

            static void GetAlLCoursesByOneTeacher()
            {
                Console.WriteLine(ConsoleMessages.ManageTeachersMenu.IdTeacherInputToGetCourse);
                int teacherId = GetId();
                _system.GetAllTeacherCourses(teacherId);
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
                _system.AddCourse(13, "maths", "2");
                _system.AddCourse(24, "english", "2");
                
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
                    userChoice = Console.ReadLine();
                }

            }
        }
}