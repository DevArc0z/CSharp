namespace Priemgetallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialiseer een lege array van 100 integer getallen
            int[] priemgetallen = new int[100];
            //bereken de eerste 100 priemgetallen en sla ze op in de array
            int teller = 0;
            int getal = 0;
            
            while (teller < 100)
            {
                if (IsPriem(getal))
                {
                    priemgetallen[teller] = getal;
                    teller++;
                }
                getal++;
            }
            //print de priemgetallen naar de console
            /* foreach (int priemgetal in priemgetallen)
             {
                 Console.Write($"{priemgetal} ");
                 if ((Array.IndexOf(priemgetallen, priemgetal) + 1) % 10 == 0)
                 {
                     Console.WriteLine();
                 }
             }*/

            for (int i = 0; i < priemgetallen.Length; i++)
            {
                Console.Write($"{priemgetallen[i]} ".PadLeft(4));
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        private static bool IsPriem(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
