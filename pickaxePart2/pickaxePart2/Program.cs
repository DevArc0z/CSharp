using System.Text;

namespace pickaxePart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Classes demo
            StringBuilder sb = new StringBuilder();
            Random rng = new Random();

            Pickaxes woodenPickaxe = new Pickaxes();
            woodenPickaxe.Name = "Wooden Pickaxe";
            woodenPickaxe.Type = "Wood";
            woodenPickaxe.Durability = rng.Next(1, 11);

            Pillager enemyPillager = new Pillager();
            enemyPillager.Name = "Enemy Pillager";
            enemyPillager.Health = rng.Next(50, 101);
            Console.WriteLine(enemyPillager.Health);
            Console.WriteLine(enemyPillager.Name);


            car ford = new car("Mustang", "Ford", 4, "Zwart", 2020);
            Console.WriteLine(ford.GetDescription());
            Console.WriteLine(ford.Drive());
            //Console.WriteLine(ford.HasValidNumberOfWheels()); //Werkt niet want is private
        }
    }
}
