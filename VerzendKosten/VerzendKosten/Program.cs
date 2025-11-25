namespace VerzendKosten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double productPrijs;
            string productPrijsString;
            double Aantal;
            string AantalInString;
            bool isProductPrijsEenInt;
            bool isHetEenAantal;
                        
            do
            {
                Console.WriteLine("Geef een prijs van een product in:");
                productPrijsString = Console.ReadLine();
                isProductPrijsEenInt = double.TryParse(productPrijsString, out productPrijs);
            }
            while (!isProductPrijsEenInt);

            do
            {
                Console.WriteLine("Hoeveel moet je van dit product?"); 
                AantalInString = Console.ReadLine();
                isHetEenAantal = double.TryParse(AantalInString, out Aantal);
            }
            while (!isHetEenAantal);

            double btwGetal;
            string btwPercentage;
            bool isPercentageEenGetal;

            do
            {
                Console.WriteLine("geeft het btw % in");
                Console.WriteLine("21%: normale btw-tarief voor alle overige producten");
                Console.WriteLine("12%: catering, sociale woningbouw, margarine, etc");
                Console.WriteLine("6%: voedingsproducten, water, medicijnen, boeken, transport, etc");
                btwPercentage = Console.ReadLine();
                isPercentageEenGetal = double.TryParse(btwPercentage, out btwGetal);
            }
            while (!isPercentageEenGetal);

            if (Aantal >= 10)
            {
                productPrijs = productPrijs - productPrijs * 0.05;
            }

            double prijs = productPrijs * Aantal;
            double verzendkostgen = 0;

            Console.WriteLine($"De prijs exclusief btw is {prijs.ToString("F2")} euro");

            if (prijs < 50)
            {
                Console.WriteLine("Verzendingskosten komt op 15 euro");
                verzendkostgen = 15;
            }
            else if (prijs >= 50 && prijs < 70)
            {
                Console.WriteLine("Verzendingskosten komt op 12 euro");
                verzendkostgen = 12;
            }
            else if (prijs > 70)
            {
                Console.WriteLine("Verzendingskosten komt op 10 euro");
                verzendkostgen = 10;
            }

            prijs += verzendkostgen;
            Console.WriteLine($"Het bedrag exclusief btw bedraagt {prijs.ToString("F2")}");
            double btwProcent = btwGetal / 100;
            double btwPrijs = prijs * btwProcent;
            prijs += prijs * btwProcent;
            double prijsInclBtw = prijs + prijs * btwProcent;

            Console.WriteLine($"Te betalen bedrag is {prijsInclBtw.ToString("F2")}");
            Console.WriteLine($"De btw bedraagt {btwPrijs.ToString("F2")}");

        }
    }
}
