using System;

namespace OOP_lab_4_17_1
{
    public class Program
    {
        public static Student student = new Student();

        static void Main(string[] args)
        {

            Console.Write("Iм'я: ");

            student.Name = Console.ReadLine();

            Console.Write("Прiзвище: ");

            student.LastName = Console.ReadLine();

            Console.Write("Група: ");

            student.Group = Console.ReadLine();

            Console.Write("Рiк: ");

            student.Year = int.Parse(Console.ReadLine());

            Console.Write("Адреса: ");

            student.Adress = Console.ReadLine();

            Console.Write("Паспорт: ");

            student.Passport = Console.ReadLine();

            Console.Write("Вiк: ");

            student.Age = int.Parse(Console.ReadLine());

            Console.Write("Телефон: ");

            student.Telehone = Console.ReadLine();

            Console.Write("Рейтинг: ");

            student.Rating = int.Parse(Console.ReadLine());

            Console.WriteLine(Student.StudentRating(student.Rating));
        }
    }
}
