namespace LaboDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Basis Dictionary
            // a) waardes toevoegen bij initialisatie
            Dictionary<string, double> portfolioBalances = new Dictionary<string, double>()
            {
                { "SQL", 20 },
                {"XRP", 1111 },
                {"DOGE", 299 }
            };

            // b) waarde toevoegen met Add()
            portfolioBalances.Add("BTC", 0.5);
            // c)waarde toevoegen met indexer
            portfolioBalances["ETH"] = 1;

            foreach (KeyValuePair<string, double> keyValuePair in portfolioBalances)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
                
            }
            Console.WriteLine();

            // 2. Crypto toevoegen
            try
            {
                portfolioBalances.Add("BTC", 10);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (!portfolioBalances.ContainsKey("BTC"))
            {
                portfolioBalances.Add("BTC", 10);
            }
            // 3. Overschrijven van waarde
            portfolioBalances["BTC"] = 10; // overschrijft de waarde

            foreach (KeyValuePair<string, double> keyValuePair in portfolioBalances)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
                
            }
            Console.WriteLine();
            // 4. Controleren of key bestaat

            if (portfolioBalances.ContainsKey("BTC"))
            {
                Console.WriteLine($"BTC balance: {portfolioBalances["BTC"]}");
            }
            // 5. Waarde ophalen met TryGetValue
            if (portfolioBalances.TryGetValue("ETH", out double ethBalance))
            {
                Console.WriteLine($"ETH balance: {ethBalance}");
            }
            // 6. Verwijderen van een item
            portfolioBalances.Remove("DOGE");
            // 7. Aantal items in de dictionary
            foreach (KeyValuePair<string, double> keyValuePair in portfolioBalances)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
                
            }
            Console.WriteLine();

            // 8. Clear de dictionary
            portfolioBalances.Clear();
        }
    }
}
