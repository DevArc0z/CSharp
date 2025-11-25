using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pickaxePart2
{
    internal class Pillager
    {
        public string Name { get; set; }

        private int _health;

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
    }
}
