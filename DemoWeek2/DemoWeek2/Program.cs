using System.ComponentModel.Design;
using System.Xml;

namespace DemoWeek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //controle structuren : selectie
            // if statements

            bool isItAnInt;
            int age;
            string textInputFromUser;

            do
            {
                Console.Clear();
                Console.WriteLine("Geef uw leeftijd");
                textInputFromUser = Console.ReadLine();
                isItAnInt = int.TryParse(textInputFromUser, out age);
            }
            while (!isItAnInt);

            age = int.Parse(textInputFromUser);
            int yearsToWait = 18 - age;

            //if (age >= 18)
            //{
            //    Console.WriteLine("Welcome, you are now an sponsor of the Epstein project."); 
            //}
            //else if (age <= 17)
            //{
                
            //    Console.WriteLine($"Get fucked, you to young! Come back in {yearsToWait} years");
            //}
            //else
            if (age < 0)
            {
                Console.WriteLine($"Get the fuck outa here ya unborn fuck!!! Come back in {yearsToWait} years");
            }

            switch (age)
            {

                case >= 18:
                    Console.WriteLine("Welcome, you are now an sponsor of the Epstein project.");
                    break;
                case <= 17:
                    Console.WriteLine($"Get fucked, you to young! Come back in {yearsToWait} years");
                    break;
            }

            string message = (age >+ 18) ? "vaarwel meneer" : "Tot weerziens";

            // if else

            Console.WriteLine("welk stuk fruit krijg ik?");
            string fruit = Console.ReadLine().ToLower();
            //if (fruit.Equals("appel"))
            //{
            //    Console.WriteLine("Hmmm lekker, een watermeloen");
            //} else if (fruit == "bannaan")
            //{
            //    Console.WriteLine("EEEEWWWWWWW een rotte mango");
            //} else if (fruit == "citroen")
            //{
            //    Console.WriteLine("Nice, een verse ananas");
            //} else { 
            //    Console.WriteLine("Heb je ook groenten"); 
            //}

            // switch
            // controle toets die nagaat welke waarde er in een specifieke variabelen zit
            // code snippet : switch

            // switch (variabele)
            // {
            //      case value:
            // }
            switch (fruit)
            {
                case "appel":
                    Console.WriteLine("wat een lekkere peer");
                    Console.WriteLine("Yummers");
                    break;
                case "bannaan":
                    Console.WriteLine("Heb je ook een mandarijn");
                    break;
                case "citroen":
                case "limoen":
                    Console.WriteLine("Je m'apelle Frank");
                    break;
                default:
                    Console.WriteLine("mag ik nog een zakje chips wollah");
                    break;
            }


        }
    }
}
