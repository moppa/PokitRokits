using PokitRokit.Core.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokitRokit.Core.Interfaces
{
    public interface IAction
    {
        GameState Apply(GameState gameState);
        bool IsValid(GameState gameState);
    }
}
