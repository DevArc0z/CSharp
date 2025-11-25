using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboClasses.Models
{
    internal class Employee
    {
		private string _firstName;

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

		private string _lastName;

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}

		private DateTime _birthDate;

		public DateTime BirthDate
		{
			get { return _birthDate; }
			set { _birthDate = value; }
		}

		private double _salary;

		public double Salary
		{
			get { return _salary; }
			set { _salary = value; }
		}
		
		public int Age
		{
			get { 
				DateTime now = DateTime.Today;
				TimeSpan yearsAlive = now - BirthDate;
                return (int)(yearsAlive.TotalDays / 365);
			} 
		}

        public Employee()
        {
            
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
		public void InceaseSalary(int percentage) 
		{ 
			Salary += Salary * percentage / 100;
        }

		// override = overschrijft het standaard gedrag
		// ALT + ENTER om snel een override te genereren
		//public override string? ToString()
		//{
		//    return base.ToString();
		//}



		public override string ToString()
		{
			return $"{FirstName} - {LastName}"
				+$" {Age} - {Salary}";
		}
	}
}
