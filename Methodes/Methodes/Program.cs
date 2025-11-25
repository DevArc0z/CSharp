using System.Reflection.Metadata.Ecma335;

namespace Methodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            ShowTitle();
            program.ShowIntro();
            program.StartGame();
        }

        public static void ShowTitle()
        {
            Console.Clear();
            Console.WriteLine(@"
 ___                         ___
| __|___ __ __ _ _ __  ___  | _ \___  ___ _ __
| _|(_-</ _/ _` | '_ \/ -_) |   / _ \/ _ \ '  \
|___/__/\__\__,_| .__/\___| |_|_\___/\___/_|_|_|
                |_|
================================================
");
        }

        public void ShowIntro()
        {
            
            Console.WriteLine("Solve the puzzles before time runs out!");
            Console.WriteLine("Press enter to start your adventure...");
            Console.ReadLine();
        }

        public void ShowColoredText(string text, ConsoleColor color, bool appendLine = false)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            if (appendLine)
            {
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public void ShowStatus(double timeLeft, bool keypadSolved, bool riddleSolved)
        {
            ShowColoredText($"Time left: {timeLeft} minutes", ConsoleColor.Blue, true);
            ShowColoredText($"Keypad: {(keypadSolved ? "solved" : "unsolved")}", ConsoleColor.Blue, true);
            ShowColoredText($"Riddle: {(riddleSolved ? "solved" : "unsolved")}", ConsoleColor.Blue, true);
            Console.WriteLine();
        }
        public void ShowMenu()
        {
            ShowColoredText("Choose an action:", ConsoleColor.White, true);
            ShowColoredText("  1) Try keypad", ConsoleColor.White, true);
            ShowColoredText("  2) Solve riddle", ConsoleColor.White, true);
            ShowColoredText("  3) Open final door", ConsoleColor.White, true);
            ShowColoredText("  9) Give up", ConsoleColor.White, true);
            ShowColoredText("Your choice: ", ConsoleColor.White, false);
        }

        public int ReadAction()
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                return choice;
            }
            return -1;
        }
        public int ApplyPenalty(int timeLeft, int penalty)
        {
            int newTime = timeLeft - penalty;
            if (newTime < 0)
            {
                newTime = 0;
            }
            ShowColoredText($"Time penalty: -{penalty} minute(s).", ConsoleColor.DarkYellow, true);
            return newTime;
        }
        public bool TryKeypad()
        {
            ShowColoredText("Enter 3-digit keypad code: ", ConsoleColor.Magenta, true);
            string input = Console.ReadLine();
            bool isValid = int.TryParse(input, out int code);

            //TODO: vul verder aan
            if (!isValid)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid code (not a number)");
                Console.ResetColor();
                return false;
            }
            else if (input.Equals("341"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Keypad solved!");
                Console.ResetColor();
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong code.");
                Console.ResetColor();
                return false;
            }
        }
        public bool SolveRiddle()
        {
            ShowColoredText("Riddle: Speak friend and enter...", ConsoleColor.Magenta, true);
            ShowColoredText("Type the secret word: ", ConsoleColor.Magenta);

            string answer = Console.ReadLine();

            //TODO: vul verder aan

            if (answer.Equals("open-sesame"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The wall slides aside");
                Console.ResetColor();
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The wall remains silent");
                Console.ResetColor();
                return false;
            }
        }
        public bool FinalDoor(bool keypadSolved, bool riddleSolved)
        {

            if (riddleSolved && keypadSolved)
            {
                ShowColoredText("Final number (1..5): ", ConsoleColor.Magenta);
            }
            if (!riddleSolved || !keypadSolved)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The final door wont budge. Solve the other puzzles first.");
                Console.ResetColor();
                return false;
            }
            //TODO: Controleer keypadSolved en riddleSolved


            string input = Console.ReadLine();

            //TODO: Vul verder aan

            bool isValid = int.TryParse(input, out int finalNumber);

            if (input.Equals("3"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You hear the lock click!");
                Console.ResetColor();
                return true;
            }
            else if (!isValid || finalNumber > 5 && finalNumber < 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("That is not between 1 and 5.");
                Console.ResetColor();
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A buzzer sounds. Wrong!");
                Console.ResetColor();
                return false;
            }
        }
        public void StartGame() { 
            int timeLeft = 15;
            bool keypadSolved = false;
            bool riddleSolved = false;
            bool escaped = false;
            do
            {
                ShowTitle();
                ShowStatus(timeLeft, keypadSolved, riddleSolved);
                ShowMenu();
                int choice = ReadAction();
                switch (choice)
                {
                    case 1:
                        if (!keypadSolved)
                        {
                            bool result = TryKeypad();
                            if (result)
                            {
                                keypadSolved = true;
                            }
                            else
                            {
                                timeLeft = ApplyPenalty(timeLeft, 2);
                            }
                        }
                        else
                        {
                            ShowColoredText("You have already solved the keypad.", ConsoleColor.Yellow, true);
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        if (!riddleSolved)
                        {
                            bool result = SolveRiddle();
                            if (result)
                            {
                                riddleSolved = true;
                            }
                            else
                            {
                                timeLeft = ApplyPenalty(timeLeft, 2);
                            }
                        }
                        else
                        {
                            ShowColoredText("You have already solved the riddle.", ConsoleColor.Yellow, true);
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        escaped = FinalDoor(keypadSolved, riddleSolved);
                        if (!escaped)
                        {
                            timeLeft = ApplyPenalty(timeLeft, 1);
                        }
                        else
                        {
                            ShowColoredText("You escaped.", ConsoleColor.DarkGreen, true);
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 9:
                        ShowColoredText("You gave up. Game over.", ConsoleColor.Red, true);
                        escaped = true;
                        break;
                    default:
                        ShowColoredText("Invalid choice. Try again.", ConsoleColor.Red, true);
                        break;
                }
            } while (!escaped && timeLeft > 0);
        }
        
    }
}
