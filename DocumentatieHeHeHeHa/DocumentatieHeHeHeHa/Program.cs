using System.Text;

namespace DocumentatieHeHeHeHa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DateTime en TimeSpan
            //// DateTime : moment/tijdstip
            //// Hoe maak ik een DateTime aan
            //// Denk aan Math.PI
            //DateTime today = DateTime.Today; // without time property
            //DateTime now = DateTime.Now; // with time property

            //DateTime startDateAcademicYear = new DateTime(2025, 09, 22);

            ////Manipuleren van datums
            //Console.WriteLine(today.DayOfWeek);
            ////AddDays ~ AddMonths ~ AddYears ~ ...
            //DateTime inTenDays = today.AddDays(10);
            //Console.WriteLine(inTenDays.DayOfWeek);

            //// Eigenschappen / Properties
            //Console.WriteLine($"Vandaag is het {today.DayOfWeek}");
            //Console.WriteLine($"nu is het {today.Hour} uur");

            //// parse
            //DateTime timeFromText = DateTime.Parse("2025-10-09");
            //Console.WriteLine(timeFromText.DayOfWeek);

            ////weergeven
            ////verkorte wijzes om data te tonen
            //Console.WriteLine($"Short date {now.ToShortDateString()}");
            //Console.WriteLine($"Short time {now.ToShortTimeString()}");
            //Console.WriteLine($"Long date{now.ToLongDateString()}");
            //Console.WriteLine($"Long time{now.ToLongTimeString()}");

            //// TimeSpan : tijdsduur/tijdspanne
            ////zowel TimeSpan als DateTime zijn OBJECTS (0bject)
            //TimeSpan duration = today - startDateAcademicYear;
            //Console.WriteLine($"Dagen sinds start academiejaar {duration.Days}");

            //// Eigenschappen / Properties
            //Console.WriteLine($"days: {duration.Days}, hours: {duration.Hours}," + 
            //    $" minutes: {duration.Minutes}, seconds: {duration.Seconds}");
            //Console.WriteLine($"totaal aantal seconde van school {duration.TotalSeconds} sec");

            //// TimeSpan aanmaken:
            //// 1. via constructor
            //// 2. via statische methodes (FromDays, FromHours, FromMinutes, FromSeconds, FromMilliseconds)
            //// Afhankelijk van het aantal waardes in de constuctor krijg je meer specifieker om de
            //// tijdspanne aan te maken ( van uren tot microseconden)
            //TimeSpan period = new TimeSpan(14, 12, 30, 10, 40);
            //TimeSpan waitTime = new TimeSpan(10, 2, 2);

            //TimeSpan threeHours = TimeSpan.FromHours(3);
            //TimeSpan tenMinutes = TimeSpan.FromMinutes(10);
            #endregion
            #region StringBuilder
            //// een backslash is een escape character om bijzondere karacters te schrijven
            //Console.WriteLine("\n\n\" Start van Stringbuilder \"\n\n");

            //// StringBuilder - tekst bouwer
            //// Aanmaken
            //StringBuilder stringBuilder = new StringBuilder();
            //StringBuilder sb = new StringBuilder("");
            //// vergelijkbaar met een lege string
            //string myText;
            //// myText += ""; // lege string
            //myText = "";
            //myText += "Dit is een tekst";

            //StringBuilder greeting = new StringBuilder("Hello... old friend");

            ////Manipuleren
            //greeting.AppendLine(" How are you?");
            //greeting.Append("It has been too long. ");
            //greeting.AppendLine("Good to see you again");

            //// resultaat opvragen
            //Console.WriteLine(greeting.ToString());
            ////Belangijk want
            //myText += greeting.ToString();

            #endregion
            #region random
            //// Random
            //// Aanmaken
            //// 
            //Random random = new Random();
            //// random met seed (startwaarde)
            //Random randomWithSeed = new Random(12345);
            //// Gebruik
            //int diceRoll = random.Next(1, 7); // 1 t/m 6
            //Console.WriteLine($"Je gooide een {diceRoll}");
            //double randomDouble = random.NextDouble(); // 0.0 t/m 1.0
            //Console.WriteLine($"Random double {randomDouble}");
            //// GUID - Globally Unique Identifier
            //// Aanmaken
            //Guid guid = Guid.NewGuid();
            //Console.WriteLine(guid.ToString());
            //// Gebruik
            //string guidAsString = guid.ToString();
            //Console.WriteLine($"Lengte van GUID {guidAsString.Length}");
            #endregion

            #region Oef1
            Console.WriteLine("Geef een ondernemingsnummer in:");
            string inputOndernemingsNr = Console.ReadLine();
            // controle numeriek
            long ondernemings;
            bool isNumeric = long.TryParse(inputOndernemingsNr, out ondernemings);
            // getal in twee knippen: de eerste acht karakters, en laatste twee karakter
            
            if (isNumeric && inputOndernemingsNr.Length == 10)
            {
                string eersteAcht = inputOndernemingsNr.Substring(0, 8);
                string laatsteTwee = inputOndernemingsNr.Substring(8, 2);

                Console.WriteLine($"Eerste acht karakters: {eersteAcht}");
                Console.WriteLine($"Laatste twee karakters: {laatsteTwee}");
                
                if (long.TryParse(eersteAcht, out long eersteAchtGetal) && int.TryParse(laatsteTwee, out int laatsteTweeGetal))
                {
                    // deling met 97 (-> rest na deling)
                    int rest = (int)(eersteAchtGetal % 97);
                    Console.WriteLine($"Rest na deling door 97: {rest}");
                    int controleGetal = 97 - rest;
                    // Vergelijking
                    if (controleGetal == laatsteTweeGetal)
                    {
                        Console.WriteLine("Het ondernemingsnummer is geldig.");
                        Console.WriteLine("Het ondernemingsnummer klopt volgens de 97-regel.");
                    }
                    else
                    {
                        Console.WriteLine("Het ondernemingsnummer is ongeldig.");
                        Console.WriteLine("Het ondernemingsnummer klopt NIET volgens de 97-regel.");
                    }
                }
                else
                {
                    Console.WriteLine("Fout bij het omzetten van de karakters naar getallen.");
                }
            }
            else
            {
                Console.WriteLine("Ongeldige invoer. Voer een ondernemingsnummer van 10 cijfers in.");
            }
            //vergelijking maken tussen rest na deling en laatste twee getallen
            
                // Deling met 97
           
            // ofwel klopt het ofwel niet -> meld aan pc
            
            #endregion
        }
    }
}
