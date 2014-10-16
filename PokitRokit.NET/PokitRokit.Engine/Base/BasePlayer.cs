using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokitRokit.Engine.Base
{
    public abstract class BasePlayer
    {
        public Guid ID { get; set; }

        public BasePlayer()
        {
            ID = Guid.NewGuid();
        }
    }
}
