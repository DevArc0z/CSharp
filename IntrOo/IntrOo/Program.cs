using System.Diagnostics.Tracing;

namespace IntrOo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words;
            string choise;
            do
            {
                Console.Clear();
                Console.WriteLine("What is your favorite song name?");
                string name = Console.ReadLine();
                Console.WriteLine(name +" sounds cool!");
                Console.WriteLine("What is it?");
                words = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(words + " is what it is");
                Console.WriteLine("Mine goes like I A I A A YA YEAH YA YEAH");
                Console.WriteLine("write s to stop or g to go");
                 choise = Console.ReadLine();
            }
            while (choise != "s");
            
        }
    }
}
