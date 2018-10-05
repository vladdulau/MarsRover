using System.Collections.Generic;
using MarsRover.DAL.DomainData;
using MarsRover.DAL;
using MarsRover.Domain;
using MarsRover.Strategies;

namespace MarsRover.Services
{
    public class RoverController
    {
        private readonly RoverContext _context;
        private RoverData _rover;
        private readonly IRoverMovementStrategy _roverMovementStrategy;
        private readonly IEnumerable<IEnumerable<Coordinates>> _map;

        public RoverController(RoverData rover,
                               IRoverMovementStrategy roverMovementStrategy,
                               RoverContext context)
        {
            this._rover = rover;
            this._roverMovementStrategy = roverMovementStrategy;
            this._context = context;
        }
        public void ChangeRover(RoverData rover) =>
            this._rover = rover;

        public void Move(IEnumerable<char> commands)
        {
            this._roverMovementStrategy.MoveRover(commands);
        }
    }
}
