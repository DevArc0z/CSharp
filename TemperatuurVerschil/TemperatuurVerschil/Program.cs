using System.Drawing;

namespace TemperatuurVerschil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region TemperatuurVerschil
            string input1;
            string input2;
            bool isValidInput;
            double temperatuur1;
            double temperatuur2;

            do
            {
                Console.Write("Geef de eerste temperatuur: ");
                input1 = Console.ReadLine();
                isValidInput = double.TryParse(input1, out temperatuur1);
            }
            while (!isValidInput);

            do
            {
                Console.Write("Geef de tweede temperatuur: ");
                input2 = Console.ReadLine();
                isValidInput = double.TryParse(input2, out temperatuur2);
            }
            while (!isValidInput);
                Console.WriteLine($"De eerste temperatuur is: {temperatuur1}°");
                Console.WriteLine($"De tweede temperatuur is: {temperatuur2}°");

                double verschil = Math.Abs(temperatuur1 - temperatuur2);
                double minimum = Math.Min(temperatuur1, temperatuur2);
                double maximum = Math.Max(temperatuur1, temperatuur2);

                Console.WriteLine($"Het verschil is: {verschil}°");
                Console.WriteLine($"Het minimum is: {minimum}°");
                Console.WriteLine($"Het maximum is: {maximum}°");
            #endregion


            #region Strings

            // strings optellen is slecht voor de performance
            string text = "Toen ik in de ogen";
            text += " van mijn geliefde keek, " + "voelde ik een warmte die mijn hart vulde met vreugde en geluk.";

            //string functie = beter

            //vergelijken van teksten
            // == slecht
            // beter: string.equals
            if ("test".Equals("TEST", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("De tekst is hetzelfde");
            }

            string voorbeeld = "Dit is een string";
            Console.WriteLine(voorbeeld);
            // length: lengte van een string
            Console.WriteLine($"De lengte van de string is: {voorbeeld.Length}");
            // charAt: eerste en laatste letter
            Console.WriteLine($"De eerste letter is: {voorbeeld[0]}");
            Console.WriteLine($"De laatste letter is: {voorbeeld[voorbeeld.Length - 1]}");
            // toUpper, toLower
            Console.WriteLine($"De string in hoofdletters: {voorbeeld.ToUpper()}");
            Console.WriteLine($"De string in kleine letters: {voorbeeld.ToLower()}");
            // trim: spaties verwijderen aan begin en einde
            Console.WriteLine($"De string zonder spaties: {voorbeeld.Trim()}");
            // substring: deel van een string
            Console.WriteLine($"De string zonder de eerste 5 letters: {voorbeeld.Substring(5)}");
            Console.WriteLine($"De string zonder de eerste 5 letters en de laatste 3 letters: {voorbeeld.Substring(5, voorbeeld.Length - 8)}");
            // replace: vervangen van tekst
            Console.WriteLine($"De string vervangen: {voorbeeld.Replace("string", "tekst")}");
            // contains: opzoeken in tekst (case sensitive)
            Console.WriteLine($"De string bevat 'is': {voorbeeld.Contains("is")}");
            Console.WriteLine($"De string bevat 'IS': {voorbeeld.Contains("IS")}");
            // indexOf: opzoeken in tekst
            Console.WriteLine($"De string bevat 'IS' (case insensitive): {voorbeeld.IndexOf("IS", StringComparison.OrdinalIgnoreCase) >= 0}");
            // startsWith, endsWith
            Console.WriteLine($"De string begint met 'Dit': {voorbeeld.StartsWith("Dit")}");
            Console.WriteLine($"De string eindigt met 'string': {voorbeeld.EndsWith("string")}");
            // split: splitsen van een string in een array
            Console.WriteLine($"De string splitten: {string.Join(", ", voorbeeld.Split(' '))}");
            // reverse: omkeren van een string
            Console.WriteLine($"De string omkeren: {new string(voorbeeld.Reverse().ToArray())}");
            // repeat: herhalen van een string
            Console.WriteLine($"De string herhalen: {string.Concat(Enumerable.Repeat(voorbeeld + " ", 3))}");
            // isNullOrEmpty, isNullOrWhiteSpace
            Console.WriteLine($"De string is leeg: {string.IsNullOrEmpty(voorbeeld)}");
            Console.WriteLine($"De string is leeg of alleen spaties: {string.IsNullOrWhiteSpace(voorbeeld)}");
            // escape, unescape, normalize
            Console.WriteLine($"De string geescaped: {voorbeeld.Replace(" ", "%20")}");
            Console.WriteLine($"De string ontdaan van escape tekens: {voorbeeld.Replace("%20", " ")}");
            Console.WriteLine($"De string genormaliseerd: {voorbeeld.Normalize()}");
            #endregion

            #region wachtwoord
            Console.WriteLine("Geef gebruikersnaam in");
            string username = Console.ReadLine();
            Console.WriteLine("Geef wachtwoord in");
            string password = Console.ReadLine();
            bool isValid = username.Trim().Equals("admin", StringComparison.OrdinalIgnoreCase);

            if (isValid)
            {
                Console.WriteLine("Je gebruikersnaam is admin");
            }
            else
            {
                Console.WriteLine("Je gebruikersnaam is niet admin");
            }

            if (password.Length >= 6)
            {
                Console.WriteLine("Je wachtwoord is minstens zes tekens lang");
            }
            #endregion
        }
    }
}
