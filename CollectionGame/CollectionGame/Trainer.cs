using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGame
{
    internal class Trainer
    {
        public string Name { get; set; }
        public Pokemon[] PokemonRoster { get; set; }
        public Trainer(string name)
        {
            Name = name;
            PokemonRoster = new Pokemon[6];
            if (!Program.IsValidPokemonRosterSize(PokemonRoster))
            {
                throw new Exception("Illegal pokemon detected");
            }
        }

        public void TradeFirstPokemon(Trainer tradePartner)
        {
            Pokemon trade = PokemonRoster[0];
            PokemonRoster[0] = tradePartner.PokemonRoster[0];
            tradePartner.PokemonRoster[0] = trade;
        }
    }
}
