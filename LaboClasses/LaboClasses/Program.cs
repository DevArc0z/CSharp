using LaboClasses.Models;
using System.Text;
namespace LaboClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voornaam: ");
            string firstName = Console.ReadLine();

            Console.Write("Achternaam: ");
            string lastName = Console.ReadLine();

            Console.Write("Geboortedatum: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Salaris: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Employee me = new Employee();
            me.FirstName = firstName;
            me.LastName = lastName;
            me.BirthDate = birthDate;
            me.Salary = (double)salary;

            me = new Employee(firstName, lastName);
            me.BirthDate = birthDate;
            me.Salary = (double)salary;

            
            int percentage;
            Console.WriteLine("Geef een percentage in van nul tot tien voor opslag");
            while (!(int.TryParse(Console.ReadLine(), out percentage)&&
                percentage>= 0 && percentage <= 10))
            {
                Console.WriteLine("Ongeldige input");
            }

            me.InceaseSalary(percentage);
            Console.WriteLine(ShowDetails(me));
            
        }

        private static string ShowDetails(Employee emp)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------------------------------------");
            sb.AppendLine($"Werknemer: {emp.FirstName} {emp.LastName}");
            sb.AppendLine($"Geboortedatum: {emp.BirthDate.ToLongDateString()} ({emp.Age})");
            sb.AppendLine($"Salaris: {emp.Salary:C2}");
            sb.AppendLine("-------------------------------------");
            sb.AppendLine($"Samenvatting: {emp.ToString()}");
            sb.AppendLine("-------------------------------------");
            return sb.ToString();
        }

        
    }
}
