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
    public class DrawAction : IAction
    {
        public DrawAction(Player player)
        {
            this.Player = player;
        }

        public Player Player { get; set; }


        public GameState Apply(States.GameState gameState)
        {
            if (!this.IsValid(gameState))
                return gameState;

            gameState.Deck.AssignSet(1, gameState.CurrentPlayer.Hand);

            int pos = gameState.Players.IndexOf(gameState.CurrentPlayer);
            //Is this the last player?
            if (pos + 1 == gameState.Players.Count)
            {
                if(gameState.Round > 2)
                {
                    //End game
                    GameEndAction eAction = new GameEndAction();

                    return eAction.Apply(gameState);
                }

                gameState.CurrentPlayer = gameState.Players.First();
                gameState.Round++;
            }
            else
            {
                //If not last player, advance
                gameState.CurrentPlayer = gameState.Players.ElementAt(pos + 1);
            }

            return gameState;
        }

        public bool IsValid(States.GameState gameState)
        {
            return gameState is DrawState && Player != null && Player == gameState.CurrentPlayer;
        }
    }
}
