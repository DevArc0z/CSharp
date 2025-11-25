namespace Rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isHetEenGeheelGetal1;
            bool isHetEenGeheelGetal2;
            string UserInput;
            int geheelGetal1;
            int geheelGetal2;

            do
            {
                Console.WriteLine("Geef een geheel getal in");
                UserInput = Console.ReadLine();
                isHetEenGeheelGetal1 = int.TryParse(UserInput, out geheelGetal1);
            }
            while (!isHetEenGeheelGetal1);

            do
            {
                Console.WriteLine("Geef een ander geheel getal in");
                UserInput = Console.ReadLine();
                isHetEenGeheelGetal2 = int.TryParse(UserInput, out geheelGetal2);
            }
            while (!isHetEenGeheelGetal2);

            Console.WriteLine("kies nu tussen +, -, *, /, %");
            string wiskundeTeken = Console.ReadLine();
            int som;
            switch (wiskundeTeken)
            {
                case "+":
                    som = geheelGetal1 + geheelGetal2;
                    Console.WriteLine(geheelGetal1 + " + " + geheelGetal2 + " = " + som);
                    break;
                case "-":
                    som = geheelGetal1 - geheelGetal2;
                    Console.WriteLine(geheelGetal1 + " - " + geheelGetal2 + " = " + som);
                    break;
                case "*":
                    som = geheelGetal1 * geheelGetal2;
                    Console.WriteLine(geheelGetal1 + " * " + geheelGetal2 + " = " + som);
                    break;
                case "/":
                    som = geheelGetal1 / geheelGetal2;
                    Console.WriteLine(geheelGetal1 + " / " + geheelGetal2 + " = " + som);
                    break;
                case "%":
                    som = geheelGetal1 % geheelGetal2;
                    Console.WriteLine(geheelGetal1 + " % " + geheelGetal2 + " = " + som);
                    break;
            }
        }
    }
}
