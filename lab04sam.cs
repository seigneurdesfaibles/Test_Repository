using System;

namespace UniversityApp
{
    class University
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int StudentCount { get; set; }
        public int FacultyCount { get; set; }
        public double AnnualBudget { get; set; }
        public double Rating { get; set; }

        public double GetBudgetPerStudent()
        {
            return AnnualBudget / StudentCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть назву унiверситету: ");
            string name = Console.ReadLine();

            Console.Write("Введiть мiсто, де розташований унiверситет: ");
            string city = Console.ReadLine();

            Console.Write("Введiть краiну: ");
            string country = Console.ReadLine();

            Console.Write("Введiть кiлькiсть студентiв: ");
            int studentCount = int.Parse(Console.ReadLine());

            Console.Write("Введiть кiлькiсть факультетiв: ");
            int facultyCount = int.Parse(Console.ReadLine());

            Console.Write("Введiть рiчний бюджет унiверситету: ");
            double annualBudget = double.Parse(Console.ReadLine());

            Console.Write("Введiть рейтинг унiверситету: ");
            double rating = double.Parse(Console.ReadLine());

            University university = new University
            {
                Name = name,
                City = city,
                Country = country,
                StudentCount = studentCount,
                FacultyCount = facultyCount,
                AnnualBudget = annualBudget,
                Rating = rating
            };

            double budgetPerStudent = university.GetBudgetPerStudent();

            Console.WriteLine();
            Console.WriteLine("Данi про унiверситет:");
            Console.WriteLine($"Назва: {university.Name}");
            Console.WriteLine($"Мiсто: {university.City}");
            Console.WriteLine($"Країна: {university.Country}");
            Console.WriteLine($"Кiлькiсть студентiв: {university.StudentCount}");
            Console.WriteLine($"Кiлькiсть факультетiв: {university.FacultyCount}");
            Console.WriteLine($"Рiчний бюджет: {university.AnnualBudget:0.00}");
            Console.WriteLine($"Рейтинг: {university.Rating:0.00}");
            Console.WriteLine($"Бюджет на одного студента: {budgetPerStudent:0.00}");
        }
    }
}
