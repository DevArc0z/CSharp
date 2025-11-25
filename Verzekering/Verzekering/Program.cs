namespace Verzekering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ageInput;
            bool isAgeJustANumber;
            int age;
            string gewestInput;
            string rookPafferInput;
            int verzekering = 0;

            do
            {
                Console.WriteLine("Hoe lang bewoon jij al de planeet aarde?");
                ageInput = Console.ReadLine();
                isAgeJustANumber = int.TryParse(ageInput, out age);
            }
            while (!isAgeJustANumber);

            if (age < 18)
            {
                Console.WriteLine("Je verzeklering gaat omhoog met 0 euro");
                verzekering += 0;
            }
            else if (age >= 18 && age < 67)
            {
                Console.WriteLine("Je vezekering gaat omhoog met 150 euro");
                verzekering += 150;
            }
            else if (age >= 67)
            {
                Console.WriteLine("Je vezekering gaat omhoog met 300 euro");
                verzekering += 300;
            }

            Console.WriteLine("Waar staat die huis van u?(Vlaanderen, Brussel, Wallonië)");
            gewestInput = Console.ReadLine().ToLower();

            switch (gewestInput)
            {
                case "brussel":
                    Console.WriteLine("Je verzekering gaat omhoog met 200 euro");
                    verzekering += 200;
                    break;
                case "vlaanderen":
                    Console.WriteLine("Je verzekering gaat omhoog met 0 euro");
                    verzekering += 0;
                    break;
                case "walonië":
                    Console.WriteLine("Je verzekering gaat omhoog met 0 euro");
                    verzekering += 0;
                    break;
            }

            Console.WriteLine("Zijt gij een cigarette paffer of vape paffer?ja/nee");
            rookPafferInput = Console.ReadLine().ToLower();

            switch (rookPafferInput)
            {
                case "ja":
                    Console.WriteLine("Je verzekering word verdubbeld");
                    verzekering = verzekering * 2;
                    break;
                case "nee":
                    Console.WriteLine("Je verzeklering gaat omhoog met 0 euro");
                    break;
            }
            
            Console.WriteLine($"De totale verzekerings factuur bedraagt {verzekering} euro, gelieve dit te betalen");
        }
    }
}
