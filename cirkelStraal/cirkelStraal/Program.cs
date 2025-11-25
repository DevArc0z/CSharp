namespace cirkelStraal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool isNumber;
            double straal;
            double pi = Math.PI;
            double oppervlakte;
            double omtrek;

            do
            {
                Console.Write("Geef de straal van die cirkel: ");
                input = Console.ReadLine();
                isNumber = double.TryParse(input, out straal);
            }
            while (!isNumber);
            double pow = Math.Pow(straal, 2);

            omtrek = 2 * pi * straal;
            Console.WriteLine($"De omtrek van die cirkel is {omtrek}");
            oppervlakte = pi * pow;
            Console.WriteLine($"De oppervlakte van die cirkel is {oppervlakte}");
        }
    }
}
