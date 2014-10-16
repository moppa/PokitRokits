using PokitRokit.Engine.Base;
using PokitRokit.Engine.TexasHoldEm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;

namespace PokitRokit.Engine
{
    [Serializable]
    [DurableService()]
    public class PokitRokit : IPokitRokit
    {
        private BaseGame Game { get; set; }

        [DurableOperation(CanCreateInstance = true)]
        public Guid StartGame()
        {
            Game = new Game();
            return Game.ID;
        }
    }
}
