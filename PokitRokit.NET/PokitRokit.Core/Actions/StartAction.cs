using DeckOfCards.PlayingCards;
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
    class StartAction : IAction
    {
        public GameState Apply(States.GameState gameState)
        {
            if (!this.IsValid(gameState))
                return gameState;

            gameState.Deck = new PlayingCardDeck();
            foreach (Player player in gameState.Players)
            {
                gameState.Deck.AssignSet(2, player.Hand);
            }

            gameState.Round = 1;

            return (DrawState)gameState;
        }

        public bool IsValid(States.GameState gameState)
        {
            return gameState.Players != null && gameState.Players.Count > 1;
        }
    }
}
