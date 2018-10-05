using MarsRover.DAL.DomainData;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.DAL.DomainData
{
    public class Coordinates
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }

       

    }
}
