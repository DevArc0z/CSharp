namespace ZeSmeltenDePaasHaas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int number;

            //Inlezen
            Console.Write("Geef je naam: ");
            name = Console.ReadLine();
            Console.Write("Geef je leeftijd: ");
            number = int.Parse(Console.ReadLine());

            //Afdruk
            Console.WriteLine("Afdruk");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Naam: {name}\t Volgende verjaardag leeftijd: {number + 1}");
            Console.WriteLine("Druk op enter om af te sluiten...");
            Console.ReadLine();
        }
    }
}
