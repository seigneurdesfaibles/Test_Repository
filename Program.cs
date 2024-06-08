using System;

namespace Lab04
{
    class Town
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public double YearIncome { get; set; }
        public double Square { get; set; }
        public bool HasPort { get; set; }
        public bool HasAirport { get; set; }

        public double GetYearIncomePerInhabitant()
        {
            return YearIncome / Population;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть назву мiста: ");
            string sName = Console.ReadLine();

            Console.Write("Введiть назву краiни: ");
            string sCountry = Console.ReadLine();

            Console.Write("Введiть назву регiону: ");
            string sRegion = Console.ReadLine();

            Console.Write("Введiть кiлькiсть населення: ");
            string sPopulation = Console.ReadLine();

            Console.Write("Введiть рiчний дохiд: ");
            string sYearIncome = Console.ReadLine();

            Console.Write("Введiть площу, кв. км: ");
            string sSquare = Console.ReadLine();

            Console.Write("Чи є у мiстi порт? (y-так, n-нi): ");
            ConsoleKeyInfo keyHasPort = Console.ReadKey();
            Console.WriteLine();

            Console.Write("Чи є у мiстi аеропорт? (y-так, n-нi): ");
            ConsoleKeyInfo keyHasAirport = Console.ReadKey();
            Console.WriteLine();

            Town OurTown = new Town
            {
                Name = sName,
                Country = sCountry,
                Region = sRegion,
                Population = int.Parse(sPopulation),
                YearIncome = double.Parse(sYearIncome),
                Square = double.Parse(sSquare),
                HasPort = keyHasPort.Key == ConsoleKey.Y,
                HasAirport = keyHasAirport.Key == ConsoleKey.Y
            };

            double YearIncomePerInhabitant = OurTown.GetYearIncomePerInhabitant();

            Console.WriteLine();
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine($"Назва: {OurTown.Name}");
            Console.WriteLine($"Країна: {OurTown.Country}");
            Console.WriteLine($"Регiон: {OurTown.Region}");
            Console.WriteLine($"Кiлькiсть населення: {OurTown.Population}");
            Console.WriteLine($"Рiчний дохiд: {OurTown.YearIncome:0.00}");
            Console.WriteLine($"Площа: {OurTown.Square:0.000}");
            Console.WriteLine(OurTown.HasPort ? "У мiстi є порт" : "У мiстi нема порту");
            Console.WriteLine(OurTown.HasAirport ? "У мiстi є аеропорт" : "У мiстi нема аеропорту");
            Console.WriteLine();
            Console.WriteLine($"Середнiй рiчний дохiд на одного громадянина: {YearIncomePerInhabitant:0.00}");
        }
    }
}
