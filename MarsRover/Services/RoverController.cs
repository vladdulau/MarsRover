using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarsRover.Domain;
using MarsRover.Strategies;

namespace MarsRover.Services
{
    public class RoverController
    {
        private Rover _rover;
        private readonly IRoverMovementStrategy _roverMovementStrategy;
        private readonly IEnumerable<IEnumerable<Coordinates>> _map;

        public RoverController(Rover rover,
                               IRoverMovementStrategy roverMovementStrategy,
                               IEnumerable<IEnumerable<Coordinates>> map)
        {
            this._rover = rover;
            this._roverMovementStrategy = roverMovementStrategy;
            this._map = map;
        }
        public void ChangeRover(Rover rover) =>
            this._rover = rover;

        public void Move(IEnumerable<char> commands)
        {
            this._roverMovementStrategy.MoveRover(commands);
        }
    }
}
