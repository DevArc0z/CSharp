namespace mijnPickaxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stonePickaxe = 131;
            int ironPickaxe = 250;
            int diamondPickaxe = 1561;
            int netheritePickaxe = 2031;

            bool isString;
            int aantalMinen;

            do
            {
                Console.Write("hoeveel blokken zou je willen minen met je stone pickaxe?");
                isString = int.TryParse(Console.ReadLine(), out aantalMinen);
                Console.WriteLine(" ");
            }
            while (isString == !true);

            if (aantalMinen >= stonePickaxe)
            {
                Console.WriteLine("RIP to my beloved stone pickaxe!!!");
            }
            else
            {
                Console.WriteLine($"Je stone pickaxe heeft nog {stonePickaxe - aantalMinen} durability over na het minen van {aantalMinen} blokken!");
            }

            if (aantalMinen >= ironPickaxe)
            {
                Console.WriteLine("RIP to my beloved iron pickaxe!!!");
            }
            else
            {
                Console.WriteLine($"Je iron pickaxe heeft nog {ironPickaxe - aantalMinen} durability over na het minen van {aantalMinen} blokken!");
            }
            if (aantalMinen >= diamondPickaxe)
            {
                Console.WriteLine("RIP to my beloved diamond pickaxe!!!");
            }
            else
            {
                Console.WriteLine($"Je diamond pickaxe heeft nog {diamondPickaxe - aantalMinen} durability over na het minen van {aantalMinen} blokken!");
            }
            if (aantalMinen >= netheritePickaxe)
            {
                Console.WriteLine("RIP to my beloved netherite pickaxe!!!");
            }
            else
            {
                Console.WriteLine($"Je netherite pickaxe heeft nog {netheritePickaxe - aantalMinen} durability over na het minen van {aantalMinen} blokken!");
            }

            Console.WriteLine(" ");
            Console.Write("Geef een element voor je pickaxe: ");
            string newElement = Console.ReadLine();
           
            int durability;
            bool dura;

            do
            {
                Console.Write($"hoeveel durability heeft je {newElement} pickaxe: ");
                dura = int.TryParse(Console.ReadLine(), out durability);
            }
            while (dura == !true);
            Console.WriteLine(" ");
                
            if (aantalMinen >= durability)
            {
                Console.WriteLine($"RIP to my beloved {newElement} pickaxe!!!");
            }
            else
            {
                Console.WriteLine($"je {newElement} pickaxe heeft nog {durability - aantalMinen} durability over na het minen van {aantalMinen} blokken!");
            }



        }
    }
}
