namespace RaadGetal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int randomNumber = rng.Next(1, 101);
            int numberOfTries = StartCheck(randomNumber);
        }
        public static void StartCheck(int randomNumber)
        {
            int myGuess = 0;
            int counter = 0;
            do
            {
                myGuess = GiveAnswer();
                counter++;

            }
            while (CheckAnswer(myGuess, randomNumber));
            return counter;
        }
        private static void GiveAnswer()
        {
            
        }
        private static bool CheckAnswer(int guess, int secret)
        {
            if (guess == secret)
            {
                
            }
        }
    } 
}
