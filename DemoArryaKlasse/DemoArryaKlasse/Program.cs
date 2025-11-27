namespace DemoArryaKlasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Julius", "Jezus", "Jef", "Jaques", "Jaak", "Jannes", "Johannes", "Jerco", "Jemal", "Jmarco" };
            PrintArray(names);
            Console.ReadLine();
            //sort

            Console.WriteLine("SORT!!!");
            Array.Sort(names);
            PrintArray(names);
            Console.ReadLine();


            //reverse

            Console.WriteLine("REVERSE!!! ");
            Array.Reverse(names);
            PrintArray(names);
            Console.ReadLine();

            //copy
            string[] names2 = names;

            string[] namesCopy = new string[names.Length];
            Array.Copy(names, namesCopy, names.Length);
            Console.WriteLine("COPY!!! ");
            names[0] = "Julius Caesar";
            Console.WriteLine("THE original");
            PrintArray(names);
            Console.WriteLine("\nTHE COPY");
            PrintArray(names2);
            Console.ReadLine();

            Console.WriteLine("IndexOf");
            int indexVanJaques = Array.IndexOf(names, "Jaques");
            Console.WriteLine($"Jaques staat op index {indexVanJaques}");
            Console.ReadLine();
            if (indexVanJaques != -1)
            {
                Console.WriteLine($"Jaques zit in de array van namen en heeft index: {indexVanJaques}");
            }
        }

        private static void PrintArray(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]} ");
            }
        }
    }
}
