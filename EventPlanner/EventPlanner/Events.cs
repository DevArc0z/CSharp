using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner
{
    internal class Events
    {
        public string TypeEvents { get; set; }
        public string Name { get; set; }
        public int AmountOfPeople { get; set; }

        public override string? ToString()
        {
            return $"{TypeEvents} - {Name}: {AmountOfPeople}";
        }
    }
}
