namespace CollectionGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region PokemonLabo

            //declaratie
            string[] pokemon;
            string[] pokemon2;

            //int[][] arrayOfNumbers

            //initialisatie
            pokemon = new string[6] { "Pikachu", "Bulbasaur", "Charmander", "Squirtle", "", "" };
            pokemon[3] = "";
            PrintPokemonRoster(pokemon);
            bool isValidSize = IsValidPokemonRosterSize(pokemon);
            Console.WriteLine($"Is valid roster size: {isValidSize}");
            pokemon2 = new string[6] { "Jinx", "Charizard", "Blastoise", "", "", "" };

            Pokemon[] pokemonStats = new Pokemon[6];

            Trainer ash = new Trainer("Ash");
            Trainer red = new Trainer("Red");
            ash.PokemonRoster[0] = new Pokemon("Pikachu", "Electric", 25 );
            red.PokemonRoster[0] = new Pokemon("Charizard", "Fire/Flying", 36 );

            Console.WriteLine($"Ash is trading {ash.PokemonRoster[0].Name}");
            ash.TradeFirstPokemon(red);
            Console.WriteLine($"Ash is receiving {ash.PokemonRoster[0].Name}");

            #endregion

            #region Demo-List

            List<string> listOfStrings;

            List<Pokemon> pokemonList;

            List<string> students;

            listOfStrings = new List<string>();
            List<double> kommagetallen = new List<double>() { 2.51, 3.7589, 4.3};
            students = new List<string>();

            students.Add("Deniz");
            students.Add("Meical");
            students.Add("Dries");
            students.Add("Meical");
            students.Add("Meical");
            students.Add("Meical");
            students.Add("Jason");
            PrintList(students);

            students[0] = "Tymo";
            PrintList(students);

            students.Remove("Meical");
            PrintList(students);

            students.RemoveAt(1);
            PrintList(students);

            students.Clear();
            PrintList(students);

            Gym firstGym = new Gym("Pewter");
            firstGym.Name = "Pewter Gym";
            firstGym.Trainers = new List<Trainer>();

            #endregion
        }

        public static void PrintList(List<string> list)
        {
                        for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"({i}: {list[i]}), ");
            }
            Console.WriteLine();
        }
        #region MeerPokemonLabo
        public static void PrintPokemonRoster(string[] pokemon)
        {

            for (int i = 0; i < pokemon.Length; i++)
            {
                if (pokemon[i] != "")
                {
                    Console.WriteLine(pokemon[i]);
                }
            }
        }

        
        public static bool IsValidPokemonRosterSize(object[] pokemon)
        {
            // Check if the array length is exactly 6 and all non-empty slots are counted
            

            // Optionally, you could check for at least one non-empty slot, but the original logic is unclear.
            // Here, we just check the length as the main criteria.             
            return pokemon.Length == 6;
        }
        #endregion
    }
}
