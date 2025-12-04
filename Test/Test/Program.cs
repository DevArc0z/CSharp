namespace Test
{
    internal class Program
    {
        static List<int> randomNumbers;
        static void Main(string[] args)
        {
                randomNumbers.Add(17);
                randomNumbers.Add(23);
                randomNumbers.Add(41);

                Console.WriteLine(randomNumbers.Count);
            
        }
    }
}
