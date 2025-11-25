using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGame
{
    internal class Gym
    {
        public string Name { get; set; }
        public List<Trainer> Trainers { get; set; }
        public Gym(string name)
        {
            Name = name;
            Trainers = new List<Trainer>();
        }
    }
}
