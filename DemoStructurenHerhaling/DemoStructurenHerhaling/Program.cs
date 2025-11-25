using System.Drawing;

namespace DemoStructurenHerhaling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loops
            //// FOR - loop
            //// for -> code snippet
            //// for(declaratie en initialisatie van de index; voorwaarde; incrementatie, omhoog gaan met 1)
            //// {code body}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Hello, mommy!");
            //    Console.WriteLine(i+1);
            //}

            //// WHILE - loop
            //// gebonden aan een voorwaarde
            //// while -> code snippet
            //// while(voorwaarde)
            //// {code body}
            //Console.WriteLine("Geef een getal");
            //int myNumber;
            //while (!int.TryParse(Console.ReadLine(), out myNumber))
            //{
            //    Console.WriteLine("WRONG CUNT, GIMME NUMBER YA HOE");
            //}
            //Console.WriteLine($"J jouw getal is: {myNumber}");

            //// DO WHILE
            //// Een herhaling die gebonden is aan een voorwaarde, maar die minstens één maal word uitgevoerd
            //// do -> code snippet
            //// do{ code body } while (voorwaarde)
            //double money = 5;
            //string answer = String.Empty;
            //do
            //{
            //    money *= 2;
            //    Console.WriteLine($"Do you want {money} euros? or double it and give it to the next person? (double/yes)");
            //    answer = Console.ReadLine();
            //}
            //while (answer.ToLower().Equals("double"));
            //Console.WriteLine($"Congratulations! You have received {money} euros");

            ////GENESTE LOOPS
            //// een lus in een lus
            //// index naam: i -> j -> k -> l
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine("*");
            //    }
            //    Console.WriteLine();
            //}

            //// CONTINUE & BREAK
            //// continue -> stopt de huidige iteratie en gaat naar de volgende
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        //break; // stopt de hele loop
            //        continue; // stopt de huidige iteratie en gaat naar de volgende
            //    }
            //    Console.WriteLine(i+1);
            //}

            //// break: stopt de hele loop
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        break; // stopt de hele loop
            //        //continue; // stopt de huidige iteratie en gaat naar de volgende
            //    }
            //    Console.WriteLine(i + 1);
            //}
            #endregion

            #region Knights vs Goblins
            //Console.WriteLine("Start van het labo!");

            //int knightHealt;
            //int goblinHealt;

            //// Randomizer tussen 0 en 100
            //Random random = new Random();
            //int randomGetal = random.Next(0, 101); // Inclusief 0, exclusief 101 (dus 0 t/m 100)
            //Console.WriteLine($"De goblin heeft {randomGetal} levenspunten");
            //goblinHealt = randomGetal;
            //string Levenspunten;

            //// Input levenspunten in een do-while loop
            //do
            //{
            //    Console.WriteLine("Geef het aantal levenspunten:");
            //    Levenspunten = Console.ReadLine();

            //    if (int.TryParse(Levenspunten, out knightHealt) && knightHealt < 101 && knightHealt > -1)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"Levenspunten is een geldig getal: {knightHealt}");
            //        Console.ResetColor();
            //        break;
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Levenspunten is geen geldig getal.");
            //        Console.ResetColor();
            //    }
            //}
            //while (true);

            //do
            //{
            //    Console.WriteLine("Wilt u healen of aanvallen? Heal/attack");
            //    string action = Console.ReadLine().ToLower();
            //    if (action == "heal")
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        knightHealt += 10;
            //        Console.WriteLine($"Je hebt 5 levenspunten geheal, je hebt nu {knightHealt}");
            //        int goblinDamage = random.Next(0, 16);

            //        Console.WriteLine($"Je ben {goblinDamage} levenspunten verloren");
            //        knightHealt -= goblinDamage;
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        Console.WriteLine($"Knights levenspunten: {knightHealt}");
            //        Console.WriteLine($"Goblins levenspunten: {goblinHealt}");
            //        if (knightHealt <= 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Je bent verslagen! Je hebt verloren!");
            //            break;
            //        }
            //        Console.ResetColor();
            //    }
            //    else if (action == "attack")
            //    {
            //        int damage = 10;
            //        goblinHealt -= damage;
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine($"Je hebt de goblin {damage} schade toegebracht, hij heeft nu nog {goblinHealt} levenspunten over.");
            //        int goblinDamage = random.Next(0, 16);

            //        Console.WriteLine($"Je ben {goblinDamage} levenspunten verloren");
            //        knightHealt -= goblinDamage;
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        Console.WriteLine($"Knights levenspunten: {knightHealt}");
            //        Console.WriteLine($"Goblins levenspunten: {goblinHealt}");
            //        if (goblinHealt <= 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("De goblin is verslagen! Je hebt gewonnen!");
            //            break;
            //        }
            //        if (knightHealt <= 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("Je bent verslagen! Je hebt verloren!");
            //            break;
            //        }
            //        Console.ResetColor();
            //    }
            //    else
            //    {
            //        int GoblinDamage = 10;
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Ongeldige actie, probeer opnieuw.");
            //        Console.WriteLine("You shall be punished by the goblin king(Mayo) and receive 10 damage");
            //        knightHealt -= 10;
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        Console.WriteLine($"Knights levenspunten: {knightHealt}");
            //        Console.WriteLine($"Goblins levenspunten: {goblinHealt}");
            //        Console.ResetColor();
            //        continue;
            //    }
            //} while (true);
            #endregion

            #region Athletes
            //string fastestAthlete = String.Empty;
            //int fastestTime = int.MaxValue;

            //Console.WriteLine("Naam Atleet: ");
            //string currentAthlete = Console.ReadLine();

            //while (!currentAthlete.ToLower().Equals("stop"))
            //{
            //    Console.WriteLine("Tijd in seconden: ");
            //    string TimeInput = Console.ReadLine();
            //    int currentTime;
            //    if (int.TryParse(TimeInput, out currentTime) && currentTime > 0)
            //    {
            //        if (currentTime < fastestTime)
            //        {
            //            fastestTime = currentTime;
            //            fastestAthlete = currentAthlete;
            //        }
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Ongeldige tijd, probeer opnieuw.");
            //        Console.ResetColor();
            //        continue;
            //    }
            //    Console.WriteLine("Naam Atleet: ");
            //    currentAthlete = Console.ReadLine();
            //}


            //if (fastestTime == int.MaxValue)
            //{
            //    Console.WriteLine("Je hebt nooit een tijd ingegeven");
            //}
            //else {
            //    Console.WriteLine($"De snelste atleet is {fastestAthlete}");
            //    Console.WriteLine($"De tijd van de snelste atleet is {fastestTime}");
            //}
            #endregion

            #region Machtsverheffing
            //int basis;
            //string basisInput;
            //do
            //{
            //    Console.WriteLine("Geef een basis: ");
            //    basisInput = Console.ReadLine();
            //}
            //while (!int.TryParse(basisInput, out basis));
            //Console.WriteLine($"{basis} tot de {1}ste = {Math.Pow(basis, 1)}");
            //for (int i = 0; i < 9; i++)
            //{
            //    Console.WriteLine($"{basis} tot de {i+2}de = {Math.Pow(basis, i+2)}");
            //}
            #endregion

            #region faculteit
            string input;
            int number;
            
            do
            {
                Console.WriteLine("Geef een getal in");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out number));
            Console.Clear();
            string faculty = input;
            int result = number;
            for (int i = number; i > 1; i--)
            {
                faculty += " * " + (i - 1).ToString();
                result *= (i - 1);
            }
            Console.WriteLine($"{faculty} = {result}");
            #endregion
        }
    }
}
