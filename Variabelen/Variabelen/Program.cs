namespace Variabelen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // H1 Variabelen en operatoren
            // Datatypes
            //Variabelen declareren
            // DATATYPE camelCasedNaam

            //declaratie
            // integer = geheel getal
            int year;
            // initialisatie
            year = 2025;
            // declaratie + initialisatie
            // string = tekst
            string name = "Meical";

            //double = kommagetal
            double decimalNumber = 0.5;

            // bonus kennis
            // andere datatypes voor getallen: short, long, float, decimal

            // bool(ean): iets dat waar of niet waar is
            // tip: schrijf de naam als een vraag
            bool isCustomerVip;
            bool hasSubscription;
            bool isAdult;
            isCustomerVip = true;
            hasSubscription = false;
            isAdult = true;

            // DateTime: datum
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;
            DateTime covid = new DateTime(2019, 3, 18); // komen we later op terug in hoofdstuk classes

            // operatoren:
            int number1 = 10;
            double number2 = 3;

            // wiskundige operatoren
            double result;
            result = number1 + number2;
            // Console.Writeline() = cw + TAB - code snippet
            Console.WriteLine(result);
            result = number1 / number2;
            Console.WriteLine(result);

            // incrementeren + decrementeren
            number1++;
            Console.WriteLine(number1);
            number1--;
            Console.WriteLine(number1);

            // % = modulo = rest na deling
            result = number1 % number2;
            Console.WriteLine($"De rest na deling van {number1} / {number2} = {result}");

            // toewijzing = één =
            result = 20;

            // vergelijkingsoperatoren
            bool isGreaterThan = number1 > number2;
            bool isGreaterThanOrEqualTo = number1 >= number2;
            bool isEqualTo = number1 == number2;

            // Logische Operatoren
            // stelt een vraag over bools met een bool als resultaat
            // OF = ||
            // EN = &&
            // NIET = !
            bool isGreaterThanOrEqualTo2 = isGreaterThan || isEqualTo;
            bool isSmallerThan = !isGreaterThanOrEqualTo2;
            bool isNumber1NotEqualToNumber2 = number1 != number2;
            isNumber1NotEqualToNumber2 = !(number1 == number2);

            // Toewijzing =
            result += 10;
            result = result + 10;
            result *= 2;
            result = result * 2;

            // !!! LET OP niet twee keer dezelfde naam declareren

            // CONVERSIES
            int numberThree = int.Parse("3");
            double percentage = 0.5;
            int numberOfStudents = 20;

            //getallen conversies:
            // *impliciete conversies
            //      percentage = numberOfStudents;
            // * expliciete conversies: casting / casten
            numberOfStudents = (int)percentage;
            numberOfStudents = (int)(percentage / 3.4);

            // toString met getallen: van getal naar tekst
            Console.WriteLine(number1.ToString());
            Console.WriteLine(number1.ToString()+1);

            // Parsing: van tekst naar getal
            // converteren naar een kommagetal
            Console.WriteLine("Geef een kommagetal in:");
            string inputTextFromUser = Console.ReadLine();
            double myNumber = double.Parse(inputTextFromUser);
        }
    }
}
