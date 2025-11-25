using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLabo
{
    internal class StarWarsCharacter
    {
        public string Name { get; set; }
        public string Alliance { get; set; }
        public string Rank { get; set; }
        public string LightSaberColor { get; set; }
        public List<string> Quotes { get; set; }


        public StarWarsCharacter()
           : this("Luke Skywalker")
        {
            Quotes = new List<string>();
        }

        public StarWarsCharacter(string name)
            : this(name, "Jedi", "Knight", "Green")
        {
            Quotes = new List<string>();
        }

        public StarWarsCharacter(string name, string alliance, string rank, string lightsaberColor)
        {
            Name = name;
            Alliance = alliance;
            Rank = rank;
            LightSaberColor = lightsaberColor;
            Quotes = new List<string>();
        }

        public string DescribeCharacter()
        {
            return $"{Name} is a {Rank} of the {Alliance} alliance, wielding a {LightSaberColor} lightsaber.";
        }
        public void ShowQuotes()
        {
            Console.WriteLine($"{Name}'s famous quotes:");
            foreach (string quote in Quotes)
            {
                Console.WriteLine($"- {quote}");
            }
        }   
        public void AddQuote( string quote)
        {
            Quotes.Add(quote);
        }
        public void RemoveQuote(string quote)
        {
            Quotes.Remove(quote);
        }
        public void KnowsQuote(string quote)
        {
            if (Quotes.Contains(quote))
            {
                Console.WriteLine($"{Name} knows the quote: \"{quote}\"");
            }
            else
            {
                Console.WriteLine($"{Name} does not know the quote: \"{quote}\"");
            }
        }
        public void ForgetAllQuotes()
        {
            Quotes.Clear();
        }
        public bool IsSith()
        {
            return "sith".Equals(this.Alliance.ToLower());
        }

        


    }
}
