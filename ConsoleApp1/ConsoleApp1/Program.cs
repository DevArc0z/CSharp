using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo Dictionaries

            //Declaratie - om wille van het feit dat het Generic types
            //bevat declareren we de generuc types tijdens declaratie

            Dictionary<string, int> scores;
            scores = new Dictionary<string, int>();

            Dictionary<double, bool> keyValuePairs = new Dictionary<double, bool>();
            Dictionary<StringBuilder, Random> keyValuePairs1 = new Dictionary<StringBuilder, Random>();

            //index notatie

            scores["Lars"] = 10;
            scores["Valentijn"] = 9;
            scores["Tymo"] = 12;

            //uitlezen
            Console.WriteLine(scores["Lars"]);
            try
            {
                Console.WriteLine(scores["Jos"]);
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("Key not found: " + ex.Message);
            }

            //voorbeeld met classes
            //customer -> portfolio
            Dictionary<Customer, Portfolio> portfolios = new Dictionary<Customer, Portfolio>();

            Customer misterX = new Customer()
            {
                Id = 1,
                Name = "Mister X",
                Address = "Elfde-linie 20",
                TelephoneNumber = "007-007007007",
                Email = "spookyboy@gmail.com"
            };

            Portfolio portfolio = new Portfolio()
            {
                Id = 1,
                DateCreated = DateTime.Now,
                Properties = new List<string>()
                {
                    "Villa X, Elfde-linie 20",
                    "Maison d'or, Rue de champs 110",
                    "Villa Y, Elfde-linie 21," +
                    "Villa Z, Elfde-linie 22"
                }
            };

            portfolios[misterX] = portfolio;
            //Hoe alle waardes opvragen uit een Dictionary zonder een integer index
            //Hoe veilig waardes opvragen die misschien niet bestaan

            foreach (KeyValuePair<string, int> keyValuePair in scores)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
            }



            foreach (string key in scores.Keys)
            {
                Console.WriteLine($"{key}: {scores[key]}");
            }


            foreach (int value in scores.Values)
            {
                Console.WriteLine($"enkel de value: {value}");
            }

            //OPGELET ELKE KEY MOET UNIEK ZIJN

            scores["Lars"] = 20;
            scores["Jip"] = 20;
            scores["Jan"] = 15;
            scores["Korneel"] = 18;
            scores["Marie"] = 19;
            scores["Sofie"] = 17;
            scores["Els"] = 16;
            scores["Tom"] = 14;
            scores["Piet"] = 13;
            scores["Klaas"] = 12;
            scores["Nele"] = 11;
            scores["An"] = 10;
            scores["Eva"] = 9;
            scores["Lotte"] = 8;
            scores["Sara"] = 7;
            scores["Mieke"] = 6;

            string keyTest = "Lars";
            if (scores.ContainsKey(keyTest))
            {
                Console.WriteLine($"{scores[keyTest]}");
            }

            string key2 = "Jos";
            if (scores.TryGetValue(key2, out int value2))
            {
                Console.WriteLine($"{key2}: {value2}");
            }
            else
            {
                Console.WriteLine($"Wollah die bestaat niet\n{key2} bestaat gewoon nie in Dictionary neef");
            }
            if (true)
            {

            }
        }
    }
}
