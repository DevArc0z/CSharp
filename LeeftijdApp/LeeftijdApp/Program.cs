namespace LeeftijdApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int birthYear;
            int year = DateTime.Today.Year;
            Console.WriteLine("Het jaar is " + year);
            Console.WriteLine("Wat is je geboortejaar");
            birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine($"Je leeftijd is {year - birthYear}");

        }
    }
}
