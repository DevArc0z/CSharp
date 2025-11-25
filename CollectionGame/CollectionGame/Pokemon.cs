using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGame
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }

        public Pokemon(string name, string type, int level)
        {
            Name = name;
            Type = type;
            Level = level;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
