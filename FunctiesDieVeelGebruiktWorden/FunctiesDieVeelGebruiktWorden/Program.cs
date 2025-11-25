namespace FunctiesDieVeelGebruiktWorden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Math class/klasse
            double pi = Math.PI;
            double tau = Math.Tau;
            double e = Math.E;

            double roundedPi = Math.Round(pi);
            Console.WriteLine(roundedPi);
            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(3.5));

            // Afronden naar boven
            Console.WriteLine(Math.Ceiling(2.5));

            // Afronden naar beneden
            Console.WriteLine(Math.Floor(2.5));

            //vierkantswortel
            Console.WriteLine(Math.Sqrt(16));

            //Machtsverheffing
            Console.WriteLine(Math.Pow(2, 3));

            //absolute waarde: maakt een negatief getal positief
            Console.WriteLine(Math.Abs(-5));

            //region -> #region <naam> #endregion
            // code in commentaar zetten: Ctrl + K + C
            // code uit commentaar halen: Ctrl + K + U

            //grootste getal van 3 getallen
            double max = Math.Max(3, Math.Max(5, 2));

        }
    }
}
