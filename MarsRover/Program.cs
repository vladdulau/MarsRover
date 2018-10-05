using System;
using System.Collections.Generic;
using System.Linq;
using MarsRover.Domain;
using MarsRover.Strategies;
using MarsRover.Services;
using MarsRover.Utils;
using Unity;
using MarsRover.DAL.DomainData;
using MarsRover.DAL;
using System.Collections.ObjectModel;

namespace MarsRover
{
    
    class Program
    {
        static public void DisplayMenu()
        {

        }
        static void InitializeRoverToDB(RoverData rover)
        {
            using (var context = new RoverContext())
            {
                rover = new RoverData()
                {
                    Routes = new List<Route>()
                    {
                        new Route()
                        {
                           Time=new DateTime(),
                           Coordinates = new List<Coordinates>()
                           {
                               new Coordinates()
                               {
                                  
                               }
                           }
                        }
                    }
                };

                context.Rovers.Add(rover);
                context.SaveChanges();
            }
        }


            static void Main(string[] args)
            {
               #region First Rover details
             

            var rover1 = new RoverData();
            var coordinates = new Coordinates
            {
                X = 1,
                Y = 1
            };

            var route = new Route
            {
                Time = DateTime.Now,
                Coordinates= new List<Coordinates>()
                {
                    coordinates
                }
            };


            var roverStrategy1 = new RoverMovementStrategy(rover1,coordinates);
            var roverController1 = new RoverController(rover1, roverStrategy1, null);
               
               
            var rover1Commands = "";

            do {
                Console.WriteLine("\tW");
                Console.WriteLine("\tA");
                Console.WriteLine("\tS");
                Console.WriteLine("\tD");
                Console.WriteLine();
                Console.Write("Enter command:");
                rover1Commands = Console.ReadLine();
                roverController1.Move(rover1Commands);

                Console.WriteLine($"Rover one ->: ({DateTime.Now}) " +
                                  $"Coordinates are :({coordinates.X},{coordinates.Y})");

                InitializeRoverToDB(rover1);

            } while (rover1Commands.CompareTo("x")<0);

           // InitializeRoverToDB(rover1);

            #endregion
            /*   roverController1.Move(rover1Commands);
                
                
               Console.WriteLine($"Rover one final position is " +
                                 $"({rover1.Position.X},{rover1.Position.Y}) " +
                                 $"and orientation {rover1.Orientation.ToDescription()}");
               #endregion
            /*
               #region Second Rover details
               var rover2 = new Rover();
               var roverStrategy2 = new RoverMovementStrategy(rover1);
               var roverController2 = new RoverController(rover1, roverStrategy2, map);
               rover1.Position = new Coordinates { X = map.ElementAt(3).ElementAt(3).X, Y = map.ElementAt(3).ElementAt(3).Y };
               rover1.Orientation = Orientation.E;

               var rover2Commands = "MMRMMRMRRM";
               roverController2.Move(rover2Commands);
               Console.WriteLine($"Rover two final position is " +
                                 $"({rover1.Position.X},{rover1.Position.Y}) " +
                                 $"and orientation {rover1.Orientation.ToDescription()}");

               #endregion 

               Console.WriteLine("\nExploring Mars!"); 
               Console.ReadKey();
           }
           */
            Console.ReadKey();
        }
    }
}
