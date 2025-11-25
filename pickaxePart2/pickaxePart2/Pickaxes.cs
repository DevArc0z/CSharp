using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pickaxePart2
{
    internal class Pickaxes
    {
        public string Name { get; set; }
        public string Type { get; set; }

        private int _durability;

        public int Durability
        {
            get { return _durability; }
            set { _durability = value; }
        }

        public string Description
        {
            get { 
                return $"{Name} is a {Type} pickaxe with {Durability} durability.";
            }
        }
        private string _mySecretMessage;


        public string secret
        {
            set { _mySecretMessage = value; }
        }
        public bool HasSecret
        {
            get
            {
                return !String.IsNullOrWhiteSpace(_mySecretMessage);
            }
        }
        public string MineBlock() {
            return "MINE MINE MINE";
        }

        public Pickaxes() : this("Unknown", "Nothing", 100)
        { 
            
        }

        public Pickaxes(string name, string type, int durability) 
        {
            Name = name;
            Type = type;
            Durability = durability;
        }

        public Pickaxes(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public Pickaxes(string name)
        {
            Name = name;
            Type = "Stone";
        }
    }
}
