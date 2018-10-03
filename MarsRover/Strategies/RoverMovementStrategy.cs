using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Domain;

namespace MarsRover.Strategies
{
    public class RoverMovementStrategy : IRoverMovementStrategy
    {

        private Rover rover;

        public RoverMovementStrategy(Rover rover)
        {
            this.rover = rover;
        }
        
   

        public void MoveRover(IEnumerable<char> commands)
        {
            foreach(var command in commands)
            {
                switch (command)
                {
                    case ('L'):TurnLeft(); break;
                    case ('R'):TurnRight(); break;
                    case ('M'):Move();break;
                    default:
                        throw new ArgumentException(string.Format("Invalid : {0}", command));
                }
            }
        }

      
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
        }
    }
}
