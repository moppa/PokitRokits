using DeckOfCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokitRokit.Core.Classes
{
    public class Hand : ICardSet
    {
        private Guid _CardSetId;
        public Guid CardSetId
        {
            get {
                if (_CardSetId == Guid.Empty)
                {
                    _CardSetId = new Guid();
                }
                return _CardSetId;
            }
        }

        public int ItemCount
        {
            get { throw new NotImplementedException(); }
        }
    }
}
