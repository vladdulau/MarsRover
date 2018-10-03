using System;
using System.Collections.Generic;
using System.Linq;
using MarsRover.Domain;
using MarsRover.Strategies;
using MarsRover.Services;
using MarsRover.Utils;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Plateau List
            var map = new List<List<Coordinates>> {

                new List<Coordinates>{
                    new Coordinates {X=0, Y=0},
                    new Coordinates {X=0, Y=1},
                    new Coordinates {X=0, Y=2},
                    new Coordinates {X=0, Y=3},
                    new Coordinates {X=0, Y=4},
                    new Coordinates {X=0, Y=5}},
                new List<Coordinates>{
                    new Coordinates {X=1, Y=0},
                    new Coordinates {X=1, Y=1},
                    new Coordinates {X=1, Y=2},
                    new Coordinates {X=1, Y=3},
                    new Coordinates {X=1, Y=4},
                    new Coordinates {X=1, Y=5}},
                new List<Coordinates>{
                    new Coordinates {X=2, Y=0},
                    new Coordinates {X=2, Y=1},
                    new Coordinates {X=2, Y=2},
                    new Coordinates {X=2, Y=3},
                    new Coordinates {X=2, Y=4},
                    new Coordinates {X=2, Y=5}},
                new List<Coordinates>{
                    new Coordinates {X=3, Y=0},
                    new Coordinates {X=3, Y=1},
                    new Coordinates {X=3, Y=2},
                    new Coordinates {X=3, Y=3},
                    new Coordinates {X=3, Y=4},
                    new Coordinates {X=3, Y=5}},
                new List<Coordinates>{
                    new Coordinates {X=4, Y=0},
                    new Coordinates {X=4, Y=1},
                    new Coordinates {X=4, Y=2},
                    new Coordinates {X=4, Y=3},
                    new Coordinates {X=4, Y=4},
                    new Coordinates {X=4, Y=5}},
                new List<Coordinates>{
                    new Coordinates {X=5, Y=0},
                    new Coordinates {X=5, Y=1},
                    new Coordinates {X=5, Y=2},
                    new Coordinates {X=5, Y=3},
                    new Coordinates {X=5, Y=4},
                    new Coordinates {X=5, Y=5}},
            };
            #endregion 
          
            #region First Rover details
            //var rover1 = new Rover();
            var rover1 = new Rover();
            var roverStrategy1 = new RoverMovementStrategy(rover1);
            var roverController1 = new RoverController(rover1, roverStrategy1, map);
            rover1.Position = new Coordinates { X=map.ElementAt(1).ElementAt(2).X, Y=map.ElementAt(1).ElementAt(2).Y };
            rover1.Orientation = Orientation.N;

            var rover1Commands = "LMLMLMLMM";
           
            roverController1.Move(rover1Commands);
       
            Console.WriteLine($"Rover one final position is " +
                              $"({rover1.Position.X},{rover1.Position.Y}) " +
                              $"and orientation {rover1.Orientation.ToDescription()}");
            #endregion

            #region Second Rover details
            var rover2 = new Rover();
            var roverStrategy2 = new RoverMovementStrategy(rover1);
            var roverController2 = new RoverController(rover1, roverStrategy2, map);
            rover1.Position = new Coordinates { X = map.ElementAt(3).ElementAt(3).X, Y = map.ElementAt(3).ElementAt(3).Y };
            rover1.Orientation = Orientation.E;

            var rover2Commands = "MMRMMRMRRM";
            roverController2.Move(rover2Commands);
            Console.WriteLine($"Rover one final position is " +
                              $"({rover1.Position.X},{rover1.Position.Y}) " +
                              $"and orientation {rover1.Orientation.ToDescription()}");

            #endregion

            Console.WriteLine("\nExploring Mars!"); 
            Console.ReadKey();
        }
    }
}
