namespace StarWarsLabo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StarWarsCharacter me = new StarWarsCharacter();
            Console.WriteLine("Geef naam");
            me.Name =  Console.ReadLine();
            Console.WriteLine("Geef aliance");
            me.Alliance = Console.ReadLine();
            Console.WriteLine("Geef rank");
            me.Rank = Console.ReadLine();
            Console.WriteLine("Geef een quote voor 'me':");
            string quote = Console.ReadLine();
            me.AddQuote(quote);



            List<StarWarsCharacter> characters = new List<StarWarsCharacter>()
            {
                new StarWarsCharacter()
                {
                    Name = "Anakin Skywalker",
                    Alliance = "Jedi",
                    Rank = "Jedi Knight",
                    LightSaberColor = "Blue",
                    Quotes = new List<string>
                    {
                        "I see through the lies of the Jedi.",
                        "This is where the fun begins.",
                        "I HATE YOU!",
                        "Your underestimate my power"
                    }
                },
                new StarWarsCharacter()
                {
                    Name = "Obi-Wan Kenobi",
                    Alliance = "Jedi",
                    Rank = "Jedi Master",
                    LightSaberColor = "Blue",
                    Quotes = new List<string>
                    {
                        "Hello there",
                        "I have the high ground.",
                        "Only a Sith deals in absolutes.",
                        "These are not the droids you are looking for.",
                        "You were the chosen one, you were meant to destroy the sith, not join them."
                    }
                },
                new StarWarsCharacter()
                {
                    Name = "Darth Vader",
                    Alliance = "Sith",
                    Rank = "Sith Lord",
                    LightSaberColor = "Red",
                    Quotes = new List<string>
                    {
                        "I find your lack of faith disturbing.",
                        "You don't know the power of the Dark Side."
                    }
                },
                new StarWarsCharacter()
                {
                    Name = "Yoda",
                    Alliance = "Jedi",
                    Rank = "Grand Master",
                    LightSaberColor = "Green",
                    Quotes = new List<string>
                    {
                        "Do or do not. There is no try.",
                        "Fear is the path to the dark side."
                    }
                },
                new StarWarsCharacter()
                {
                    Name = "Darth Sidious",
                    Alliance = "Sith",
                    Rank = "Emperor",
                    LightSaberColor = "Red",
                    Quotes = new List<string>
                    {
                        "Power! Unlimited power!",
                        "The Dark Side of the Force is a pathway to many abilities some consider to be unnatural.",
                        "DO IT!",
                        "Have you ever heard of Darth Plaegus the Wise.",
                        "It's treason then."
                    }
                },
                new StarWarsCharacter()
                {
                    Name = "Luke Skywalker",
                    Alliance = "Jedi",
                    Rank = "Jedi Knight",
                    LightSaberColor = "Green",
                    Quotes = new List<string>
                    {
                        "I am a Jedi, like my father before me.",
                        "No one’s ever really gone."
                    }
                },
                new StarWarsCharacter()
                {
                    Name = "Darth Maul",
                    Alliance = "Sith",
                    Rank = "Sith Apprentice",
                    LightSaberColor = "Red",
                    Quotes = new List<string>
                    {
                        "At last, we will reveal ourselves to the Jedi. At last, we will have revenge.",
                        "I was lost, and yet I found purpose again."
                    }
                },
                new StarWarsCharacter()
                {
                    Name = "Qui-Gon Jinn",
                    Alliance = "Jedi",
                    Rank = "Jedi Master",
                    LightSaberColor = "Green",
                    Quotes = new List<string>
                        {
                            "Your focus determines your reality.",
                            "Feel, don’t think. Trust your instincts."
                        }
                    }
                };
            characters.Add(me);

            characters[1].RemoveQuote("Hello there");

            int index = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Deel 2 Collections:\n");
                Console.WriteLine(characters[index].DescribeCharacter());
                Console.WriteLine("\nQuotes:");
                characters[index].ShowQuotes();

                Console.WriteLine("\nGebruik de pijltjestoetsen om te navigeren (Links/Rechts), of druk op Escape om af te sluiten.");

                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.RightArrow)
                {
                    index = (index + 1) % characters.Count;
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    index = (index - 1 + characters.Count) % characters.Count;
                }
                else if (key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            private static void List<StarWarsCharacter> FilterSiths(List<StarWarsCharacter> characters)
        {
            List<StarWarsCharacter> filteredList = new List<StarWarsCharacter>();
            for (int i = 0; i < characters.count; i++)
            {
                if (characters[i].IsSith())
                {
                    filteredList.Add(characters[i])
                }
            }
        }

    }
    }
}
