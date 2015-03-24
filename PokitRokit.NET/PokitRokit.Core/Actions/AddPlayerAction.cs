using PokitRokit.Core.Classes;
using PokitRokit.Core.Interfaces;
using PokitRokit.Core.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokitRokit.Core.Actions
{
    public class AddPlayerAction : IAction
    {
        public AddPlayerAction(string Name)
        {
            this.Name = Name;
        }

        private string Name;

        public bool IsValid(States.GameState gameState)
        {
            return gameState != null && gameState is SetupState;

        }

        States.GameState IAction.Apply(States.GameState gameState)
        {
            if (!this.IsValid(gameState))
                return gameState;

            Player p = new Player(this.Name);
            gameState.Players.Add(p);

            if (gameState.CurrentPlayer == null)
                gameState.CurrentPlayer = p;

            return gameState;
        }
    }
}
