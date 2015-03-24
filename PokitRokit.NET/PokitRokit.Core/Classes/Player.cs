using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokitRokit.Core.Classes
{
    public class Player
    {
        public Player(string Name)
        {
            Hand = new Hand();
        }

        public string Name { get; set; }
        public Hand Hand { get; set; }
    }
}
