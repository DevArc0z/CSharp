using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSelectieControls
{
    internal class Companion
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool isEvil { get; set; }
        public Companion(string name, DateTime birthDate, bool isEvill)
        {
            Name = name;
            BirthDate = birthDate;
            isEvil = isEvill;
        }
        public override string? ToString()
        {
            return $"{Name} (Age: {(int)(DateTime.Now - BirthDate).TotalDays / 365}) " + (isEvil ? " [Evil]" : "");
        }
    }
}
