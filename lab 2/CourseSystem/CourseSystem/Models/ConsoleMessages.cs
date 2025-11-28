namespace CourseSystem.Models;

public static class ConsoleMessages
{
    public static class MainMenu
    {
        private const string Title = "------ СИСТЕМА УПРАВЛЕНИЯ КУРСАМИ ------";

        private const string Options =
            "1. Управление курсами\n" +
            "2. Управление преподавателями\n";

        private const string ChoiceOffer = "Выберите нужный пункт:";

        public const string UnknownOperation = "Неизвестная операция!";

        public static string AllMessage = string.Join("\n", [Title, Options, ChoiceOffer]);
    }

    public static class ManageCourseMenu
    {
        private const string Title = "------ УПРАВЛЕНИЕ КУРСАМИ ------";

        private const string Options =
            "1. Добавление курса\n" +
            "2. Удаление курса\n" +
            "3. Вывод всех курсов\n" +
            "4. Получить список студентов, записанных на конкретный курс\n";

        private const string ChoiceOffer = "Выберите нужное действие:";

        public const string UnknownOperation = "Неизвестная операция в курсах!";
        
        public static string AllMessage = string.Join("\n", [Title, Options, ChoiceOffer]);
        
    }

    public static class AddCourseMenu
    {
        public const string IdInput = "Введите id курса:\n";
        public const string TitleInput = "Введите название курса:\n";
        public const string IdMistake = "Введён некорректный Id - повторите ввод!";
        public const string EmptyTitle = "Пустая строка не может быть названием - повторите ввод!";
        public const string IncorrectTypeChoice = "Недопустимый тип курса - повторите ввод!";
        public const string TypeOfCourseChoice = 
            "Выберите тип курса:\n" + 
            "- онлайн (1)\n" + 
            "- оффлайн (2):\n";
    }

    public static class RemoveCourseMenu
    {
        public const string IdInput= "Введите id курса, который хотите удалить:\n";
    }

    public static class GetCourseMenu
    {
        public const string AllCourses = "Вот все курсы, доступные на данный момент:\n";
    }

    public static class ManageTeachersMenu
    {
        public const string Title = "------ УПРАВЛЕНИЕ ПРЕПОДАВАТЕЛЯМИ ------";
        private const string Options =
            "1. Назначение преподавателя на курс\n" +
            "2. Получение всех курсов, которые ведет конкретный преподаватель\n";
        private const string ChoiceOffer = "Выберите нужный пункт:";
        public static string AllMessage = string.Join("\n", [Title, Options, ChoiceOffer]);
        public const string ListOfTeachers = "Вот список доступных преподавателей:";
        public const string Teachers = 
            "5677 Филатов Александр Сергеевич\n" +
            "5678 Иванова Мария Дмитриевна\n" +
            "5679 Петров Алексей Владимирович\n" +
            "5680 Сидорова Екатерина Андреевна\n" +
            "5681 Козлов Денис Олегович\n" +
            "5682 Николаева Ольга Сергеевна\n" +
            "5683 Васильев Игорь Петрович\n" +
            "5684 Алексеева Татьяна Викторовна\n" +
            "5685 Михайлов Павел Александрович\n" +
            "5686 Семенова Юлия Игоревна";
        public const string IdTeacherInput = "Напишите id того, которого хотите назначить:";
        public const string IdCourseInput = "Напишите id курса, для которого хотите назначить преподавателя:";
        public const string IdTeacherInputToGetCourse = "Напишите id преподавателя, чьи курсы хотите узнать:";

    }
}