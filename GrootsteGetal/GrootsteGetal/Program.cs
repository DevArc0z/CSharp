using System.Threading.Channels;

namespace GrootsteGetal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoerGetal1;
            string invoerGetal2;
            string invoerGetal3;
            int leesGetal1;
            int leesGetal2;
            int leesGetal3;

            bool isInvoerGetal1EenInt;
            bool isInvoerGetal2EenInt;
            bool isInvoerGetal3EenInt;

            do
            {
                Console.Clear();
                Console.WriteLine("Geef een eerste getal in");
                invoerGetal1 = Console.ReadLine();
                isInvoerGetal1EenInt = int.TryParse(invoerGetal1, out leesGetal1);
            }
            while (!isInvoerGetal1EenInt);

            do
            {
                Console.Clear();
                Console.WriteLine("Geef een tweede getal in");
                invoerGetal2 = Console.ReadLine();
                isInvoerGetal2EenInt = int.TryParse(invoerGetal2, out leesGetal2);
            }
            while (!isInvoerGetal2EenInt);
            do
            {
                Console.Clear();
                Console.WriteLine("Geef een derde getal in");
                invoerGetal3 = Console.ReadLine();
                isInvoerGetal3EenInt = int.TryParse(invoerGetal3, out leesGetal3);
            }
            while (!isInvoerGetal3EenInt);
            string getal;
            if (leesGetal1>leesGetal2 && leesGetal1 > leesGetal3)
            {
                Console.WriteLine($"getal {leesGetal1} is groter als getal {leesGetal2} en {leesGetal3}");
            }
            else if (leesGetal1<leesGetal2 && leesGetal2 > leesGetal3)
            {
                Console.WriteLine($"getal {leesGetal2} is groter als getal {leesGetal1} en {leesGetal3}");
            }
            else if (leesGetal1 < leesGetal3 && leesGetal2 < leesGetal3)
            {
                Console.WriteLine($"getal {leesGetal3} is groter als getal {leesGetal1} en {leesGetal2}");
            }
        }
    }
}
