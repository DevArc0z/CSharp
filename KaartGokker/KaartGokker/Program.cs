namespace KaartGokker
{
    internal class Program
    {
        private static string[] suits = { "Harten", "Ruiten", "Klaver", "Schoppen" };
        private static string[] symbols = { "Boer", "Vrouw", "Koning" };
        private static Dictionary<Card, int> _pulledCards = new Dictionary<Card, int>();
        static void Main(string[] args)
        {
            Console.WriteLine(@"
          _____
         |A .  | _____
         | /.\ ||A ^  | _____
         |(_._)|| / \ ||A _  | _____
         |  |  || \ / || ( ) ||A_ _ |
         |____V||  .  ||(_'_)||( v )|
                |____V||  |  || \ / |
                       |____V||  .  |
                              |____V|");
            Console.WriteLine("--Genereer Deck--");
            List<Card> cards = new List<Card>();
            foreach (var suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {

                    switch (i)
                    {
                        case 11:
                            cards.Add(new Card(suit, symbols[0]));
                            break;
                        case 12:
                            cards.Add(new Card(suit, symbols[1]));
                            break;
                        case 13:
                            cards.Add(new Card(suit, symbols[2]));
                            break;
                        default:
                            cards.Add(new Card(suit, i.ToString()));
                            break;

                    }
                }
            }
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
            Console.WriteLine("-- Start Game --");
            int credits = 1000;
            int stake;
            string chosenSuit;
            string hystory = "";
            while (credits > 0 && cards.Count > 0)
            {
                Console.WriteLine($"Je hebt {credits} credits.");
                stake = GetStake(credits);
                chosenSuit = GetCardChoice();
                credits = PullCard(chosenSuit, credits, stake);
                Console.WriteLine("\nHISTORY\n");
                ShowHistory();
            }
            
        }

        private static void ShowHistory()
        {
            foreach (var item in _pulledCards)
            {
                Card card = item.Key;
                Console.WriteLine($"{item.Key.Name} {item.Value} times");
            }
        }





        //inzet vragen
        private static int GetStake(int credits)
        {
            int bet;
            while (true)
            {
                Console.Write("Wat is je inzet? ");
                if (int.TryParse(Console.ReadLine(), out bet) && bet > 0 && bet <= credits)
                {
                    return bet;
                }
                Console.WriteLine("Ongeldige inzet. Probeer het opnieuw.");
            }
        }
        // kleur vragen
        private static string GetCardChoice()
        {
            while (true)
            {
                Console.Write("Kies een kleur (Rood/Zwart): ");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "rood" || choice == "zwart")
                {
                    return choice;
                }
                Console.WriteLine("Ongeldige keuze. Probeer het opnieuw.");
            }

        }

        private static int PullCard(string cardChoice, int credits, int stake)
        {
            // Kaart trekken
            Random rand = new Random();
            string[] suits = { "Harten", "Ruiten", "Klaver", "Schoppen" };
            string suit = suits[rand.Next(suits.Length)];
            string[] symbols = { "Boer", "Vrouw", "Koning" };
            int symbolIndex = rand.Next(1, 14);
            string symbol;
            switch (symbolIndex)
            {
                case 11:
                    symbol = symbols[0];
                    break;
                case 12:
                    symbol = symbols[1];
                    break;
                case 13:
                    symbol = symbols[2];
                    break;
                default:
                    symbol = symbolIndex.ToString();
                    break;
            }
            Card drawnCard = new Card(suit, symbol);
            Console.WriteLine($"Getrokken kaart: {drawnCard.Name} ({drawnCard.Color})");
            // Winnen of verliezen
            if (drawnCard.Color.ToLower() == cardChoice)
            {
                credits += stake;
                Console.WriteLine($"Je hebt gewonnen! Nieuwe credits: {credits}");
                _pulledCards.Add(drawnCard, +stake);
            }
            else
            {
                credits -= stake;
                Console.WriteLine($"Je hebt verloren. Nieuwe credits: {credits}");
                _pulledCards.Add(drawnCard, -stake);
            }
            
            return credits;
        }


    }
}
