using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.DAL.DomainData
{
    public class RoverData
    {
        public int Id { get; set; }
        public ICollection<Route> Routes { get; set; }

    }
}
