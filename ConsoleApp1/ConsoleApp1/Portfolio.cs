using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Portfolio
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public List<string> Properties { get; set; }
    }
}
