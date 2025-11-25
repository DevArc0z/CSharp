namespace AgeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isInputANumber;
            int Year;
            string inputYear;
            int age;

            do
            {
                Console.WriteLine("In welk jaar ben je geboren?");
                inputYear = Console.ReadLine();
                isInputANumber = int.TryParse(inputYear, out Year);
            }
            while (!isInputANumber);

            age = DateTime.Now.Year - Year;

            if (Year < 1900)
            {
                Console.WriteLine("You dead, go join paat and hampter!");
            }
            else if (Year > DateTime.Now.Year)
            {
                Console.WriteLine("Get the fuck outa here you unborn fetus!!!"); 
            }else if (age >= 18)
            {
                Console.WriteLine("You is legal/White");
            }
            else
            {
                Console.WriteLine("you is illegal/Mexican");
            }

        }
    }
}
