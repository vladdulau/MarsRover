using MarsRover.DAL.DomainData;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.DAL.DomainData
{
    public class Route
    {
        
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int RoverDataId { get; set; }
        public RoverData Rover { get; set; }
        public ICollection<Coordinates> Coordinates { get; set; }

       
    }
}
