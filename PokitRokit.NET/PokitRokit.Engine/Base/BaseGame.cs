using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokitRokit.Engine.Base
{
    public abstract class BaseGame
    {
        public List<BasePlayer> Players { get; set; }
        public Guid ID { get; set; }

        public BaseGame()
        {
            ID = Guid.NewGuid();
        }
    }
}
