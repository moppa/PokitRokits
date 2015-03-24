using PokitRokit.Core.Interfaces;
using PokitRokit.Core.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokitRokit.Core.Actions
{
    public class GameEndAction : IAction
    {
        public GameState Apply(States.GameState gameState)
        {
            if (!this.IsValid(gameState))
                return gameState;

            return (EndState)gameState;
        }

        public bool IsValid(States.GameState gameState)
        {
            return gameState is DrawState;
        }
    }
}
