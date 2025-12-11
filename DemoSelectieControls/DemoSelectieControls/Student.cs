using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSelectieControls
{
    internal class Student
    {
        public string Name { get; set; }
        public Companion Pet { get; set; }
        public string House { get; set; }
        public bool IsPrefect { get; set; }
        public int Friends { get; set; }

        public Student(string name, Companion pet, string house, bool isPrefect, int friends)
        {
            Name = name;
            Pet = pet;
            House = house;
            IsPrefect = isPrefect;
            Friends = friends;
        }

        // TODO: ToString override
        public override string ToString()
        {
            return $"{Name} from {House}, with {Friends} friends with a pet {Pet}" + (IsPrefect ? ", Prefect" : "");
        }
    }
}
