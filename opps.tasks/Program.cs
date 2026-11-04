using opps.tasks;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentServices service = new StudentServices();

            // Butun telebeler
            var students = service.GetAllStudents();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} - {student.FullName} - {student.Age} - {student.Email}");
            }

            // Yaslarin cemi
            Console.WriteLine("Yaslarin cemi: " + service.SumOfAges());

            // Telebelerin sayi
            Console.WriteLine("Telebelerin sayi: " + service.GetStudentsCount());

            // Yas ortalamasi
            Console.WriteLine("Yas ortalamasi: " + service.GetAverageAge());

            // Adla axtaris
            var studentByName = service.GetStudentByName("Ali Veliyev");
            Console.WriteLine("Axtarilan telebe: " + studentByName?.FullName);

            // Yasa gore artan siralama
            var sortedStudents = service.GetStudentsSortedByAge();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FullName + " - " + student.Age);
            }

            // Yasa gore azalan siralama
            var descendingStudents = service.GetStudentsSortedByAgeDescending();

            foreach (var student in descendingStudents)
            {
                Console.WriteLine(student.FullName + " - " + student.Age);
            }
        }
    }
}