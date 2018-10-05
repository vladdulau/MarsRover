using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.DAL.DomainData;
using MarsRover.Domain;

namespace MarsRover.Strategies
{
    public class RoverMovementStrategy : IRoverMovementStrategy
    {

        private RoverData _rover;
        private Coordinates _coordinates;

        public RoverMovementStrategy(RoverData rover, Coordinates coordinates)
        {
            this._coordinates = coordinates;
            this._rover = rover;
        }
        
   

        public void MoveRover(IEnumerable<char> commands)
        {
            foreach(var command in commands)
            {
                switch (command)
                {
                    case ('w'):MoveForward(); break;
                    case ('s'):MoveBackward(); break;
                    case ('d'):MoveRight(); break;
                    case ('a'):MoveLeft();break;
                    case ('x'):break;
                    default:
                        throw new ArgumentException(string.Format("Invalid : {0}", command));
                }
            }
        }

        public void MoveForward()
        {
            _coordinates.Y++;
            if (_coordinates.Y > 5)
                _coordinates.Y = 5;
        }
        public void MoveBackward()
        {
            _coordinates.Y--;
            if (_coordinates.Y < 0)
                _coordinates.Y = 0;
        }
        public void MoveLeft()
        {
            _coordinates.X--;
            if (_coordinates.X < 0)
                _coordinates.X = 0;
        }

        public void MoveRight()
        {
            _coordinates.X++;
            if (_coordinates.X > 5)
                _coordinates.X = 5;
        }

 /*
        private void TurnRight()
        {
            if (rover.Orientation + 1 > Orientation.W)
                rover.Orientation = Orientation.N;
            else
                rover.Orientation += 1;

        }
        private void TurnLeft()
        {
            if (rover.Orientation - 1 < Orientation.N)
                rover.Orientation = Orientation.W;
            else
                rover.Orientation -= 1;
        }
        private void Move()
        {
            if (rover.Orientation == Orientation.N)
            {
                rover.Position.Y++;
                if (rover.Position.Y > 5)
                    rover.Position.Y = 5;
            }
            else if(rover.Orientation == Orientation.E)
            {
                rover.Position.X++;
                if (rover.Position.X > 5)
                    rover.Position.X = 5;
            }
            else if (rover.Orientation == Orientation.S)
            {
                rover.Position.Y--;
                if (rover.Position.Y < 0)
                    rover.Position.Y = 0;
            }
            else if (rover.Orientation == Orientation.W)
            {
                rover.Position.X--;
                if (rover.Position.X < 0)
                    rover.Position.X = 0;
            }
        } */
    }
}
