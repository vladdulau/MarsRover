using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Strategies
{
    public interface IRoverMovementStrategy
    {
        void MoveRover(IEnumerable<char> commands);
    }
}
