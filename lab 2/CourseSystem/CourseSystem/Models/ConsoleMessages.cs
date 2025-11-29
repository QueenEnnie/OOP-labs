namespace CourseSystem.Models;

public static class ConsoleMessages
{
    public static class MainMenu
    {
        private const string Title = "\n------ СИСТЕМА УПРАВЛЕНИЯ КУРСАМИ ------";

        private const string Options =
            "1. Управление курсами\n" +
            "2. Управление преподавателями\n" +
            "*Чтобы выйти, напишите end\n";

        private const string ChoiceOffer = "Выберите нужный пункт:";

        public const string UnknownOperation = "Неизвестная операция!\n";

        public static string AllMessage = string.Join("\n", [Title, Options, ChoiceOffer]);
    }

    public static class ManageCourseMenu
    {
        private const string Title = "\n------ УПРАВЛЕНИЕ КУРСАМИ ------";

        private const string Options =
            "1. Добавление курса\n" +
            "2. Удаление курса\n" +
            "3. Вывод всех курсов\n" +
            "4. Получить список студентов, записанных на конкретный курс\n" +
            "*Чтобы выйти, напишите end\n";

        private const string ChoiceOffer = "Выберите нужное действие:";

        public const string UnknownOperation = "Неизвестная операция в курсах!";
        
        public static string AllMessage = string.Join("\n", [Title, Options, ChoiceOffer]);

        public const string IdCourseToGetStudents = "Напишите ид курса, студентов которого хотите узнать:";
        public const string IdInput = "Введите id курса:";
        
        public const string TitleInput = "Введите название курса:";
        
        public const string IdMistake = "Введён некорректный id - повторите ввод!";
        public const string IdAlreadyExisting = "Курс с таким id уже есть - повторите ввод!";
        public const string CourseNotExisted = "Курс не существует - повторите ввод!";
        
        public const string EmptyTitle = "Пустая строка не может быть названием - повторите ввод!";
        
        public const string IncorrectTypeChoice = "Недопустимый тип курса - повторите ввод!";
        public const string SuccessfulCreation = "Новый курс успешно создан!\n";
        
        public const string TypeOfCourseChoice = 
            "Выберите тип курса:\n" + 
            "- онлайн (1)\n" + 
            "- оффлайн (2):";
        
        public const string IdInputToDelete= "Введите id курса, который хотите удалить:\n";
        public const string SuccessfulDeletion = "Курс успешно удалён!";
        
        public const string AllCourses = "Вот все курсы, доступные на данный момент:";
    }
    
    public static class ManageTeachersMenu
    {
        private const string Title = "\n------ УПРАВЛЕНИЕ ПРЕПОДАВАТЕЛЯМИ ------";
        private const string Options =
            "1. Назначение преподавателя на курс\n" +
            "2. Получение всех курсов, которые ведет конкретный преподаватель\n" +
            "*Чтобы выйти, напишите end\n";
        
        private const string ChoiceOffer = "Выберите нужный пункт:";
        public static string AllMessage = string.Join("\n", [Title, Options, ChoiceOffer]);
        public const string ListOfTeachers = "Вот список доступных преподавателей:";
        public const string TeacherNotExisted = "Преподаватель не существует - повторите ввод!";
        public const string IdTeacherInput = "Напишите id того, которого хотите назначить:";
        public const string IdCourseInput = "Напишите id курса, для которого хотите назначить преподавателя:";
        public const string IdTeacherInputToGetCourse = "Напишите id преподавателя, чьи курсы хотите узнать:";
        public const string SuccessfulAppointment = "Назначение преподавателя прошло успешно!";
    }
}