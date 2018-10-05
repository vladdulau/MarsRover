using MarsRover.Domain;
using MarsRover.Strategies;
using MarsRover.Services;
using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using MarsRover.DAL.DomainData;

namespace RoverTests
{
    public class UnitTest1
    {
       
 
        [Fact]
        public void RoverMovementTest()
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
            var rover1 = new Rover();
            var roverStrategy1 = new RoverMovementStrategy(rover1);
            var roverController1 = new RoverController(rover1, roverStrategy1,map);

            rover1.Position = new Coordinates { X = map.ElementAt(1).ElementAt(2).X, Y = map.ElementAt(1).ElementAt(2).Y }; 

            rover1.Orientation = Orientation.E;
           
            var roverCommands1 = "M";
            roverController1.Move(roverCommands1);

            Assert.Equal(2,rover1.Position.X);
            Assert.Equal(2,rover1.Position.Y);

            var roverCommands2 = "MMMM";
            roverController1.Move(roverCommands2);
            Assert.Equal(5, rover1.Position.X);
            Assert.Equal(2, rover1.Position.Y);

            //Arrange
            //Act
            //Assert
        }
        [Fact]
        public void RoverOrientationLeftTest()
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
            var rover1 = new Rover();
            var roverStrategy1 = new RoverMovementStrategy(rover1);
            var roverController1 = new RoverController(rover1, roverStrategy1, map);

            rover1.Position = new Coordinates { X = map.ElementAt(1).ElementAt(1).X, Y=map.ElementAt(1).ElementAt(1).Y };
            rover1.Orientation = Orientation.S;

            var rover1Commands = "L";
            roverController1.Move(rover1Commands);

            Assert.Equal(Orientation.E, rover1.Orientation);

        }

        [Fact]
        public void RoverOrientationRightTest()
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
            var rover1 = new Rover();
            var roverStrategy1 = new RoverMovementStrategy(rover1);
            var roverController1 = new RoverController(rover1, roverStrategy1, map);

            rover1.Position = new Coordinates { X = map.ElementAt(1).ElementAt(1).X, Y = map.ElementAt(1).ElementAt(1).Y };
            rover1.Orientation = Orientation.S;

            var rover1Commands = "R";
            roverController1.Move(rover1Commands);

            Assert.Equal(Orientation.W, rover1.Orientation);

        }




        [Fact]
        public void RoverMoveAndTurnRightTest()
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
            var rover1 = new Rover();
            var roverStrategy1 = new RoverMovementStrategy(rover1);
            var roverController1 = new RoverController(rover1, roverStrategy1, map);

            rover1.Position = new Coordinates { X = map.ElementAt(1).ElementAt(2).X, Y = map.ElementAt(1).ElementAt(2).Y };
            rover1.Orientation = Orientation.N;

            var rover1Commands = "MRM";
            roverController1.Move(rover1Commands);

            Assert.Equal(2, rover1.Position.X);
            Assert.Equal(3, rover1.Position.Y);
            Assert.Equal(Orientation.E, rover1.Orientation);

        }

        [Fact]
        public void RoverMoveAndTurnLeftTest()
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
            var rover1 = new Rover();
            var roverStrategy1 = new RoverMovementStrategy(rover1);
            var roverController1 = new RoverController(rover1, roverStrategy1, map);

            rover1.Position = new Coordinates { X = map.ElementAt(1).ElementAt(2).X, Y = map.ElementAt(1).ElementAt(2).Y };
            rover1.Orientation = Orientation.N;

            var rover1Commands = "MLM";
            roverController1.Move(rover1Commands);

            Assert.Equal(0, rover1.Position.X);
            Assert.Equal(3, rover1.Position.Y);
            Assert.Equal(Orientation.W, rover1.Orientation);

        }

        [Fact]
        public void RoverMoveOutOfPlateauNorth()
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
            var rover1 = new Rover();
            var roverStrategy1 = new RoverMovementStrategy(rover1);
            var roverController1 = new RoverController(rover1, roverStrategy1, map);

            rover1.Position = new Coordinates { X = map.ElementAt(1).ElementAt(2).X, Y = map.ElementAt(1).ElementAt(2).Y };
            rover1.Orientation = Orientation.N;

            var rover1Commands = "MMMM";
            roverController1.Move(rover1Commands);

            Assert.Equal(1, rover1.Position.X);
            Assert.Equal(5, rover1.Position.Y);
           
        }

        [Fact]
        public void RoverMoveOutOfPlateauSouth()
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
            var rover1 = new Rover();
            var roverStrategy1 = new RoverMovementStrategy(rover1);
            var roverController1 = new RoverController(rover1, roverStrategy1, map);

            rover1.Position = new Coordinates { X = map.ElementAt(1).ElementAt(2).X, Y = map.ElementAt(1).ElementAt(2).Y };
            rover1.Orientation = Orientation.S;

            var rover1Commands = "MMMM";
            roverController1.Move(rover1Commands);

            Assert.Equal(1, rover1.Position.X);
            Assert.Equal(0, rover1.Position.Y);

        } 

    }
}
