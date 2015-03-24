using DeckOfCards.PlayingCards;
using PokitRokit.Core.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokitRokit.Core.States
{
    public abstract class GameState
    {
        public ObservableCollection<Player> Players;
        public Player CurrentPlayer;
        public PlayingCardDeck Deck;
        public int Round { get; set; }
    }
}