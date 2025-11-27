using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaartGokker
{
    internal class Card
    {
        public string Suit { get; set; }
        public string Symbol { get; set; }

        public string Color { get
            {
                if (Suit == "Harten" || Suit == "Ruiten")
                {
                    return "Rood";
                }
                else
                {
                    return "Zwart";
                }
            }
        }
        public string Name { get 
            { 
                return $"{Suit} {Symbol}";
            } 
        }

        public Card(string suit, string symbol)
        {
            Suit = suit;
            Symbol = symbol;
        }
    }
}
