using MarsRover.DAL.DomainData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.DAL
{
    public class RoverContext:DbContext
    {
        public DbSet<RoverData> Rovers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Coordinates> Coordinates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = (localdb)\\mssqllocaldb; Database = RoverAppData; Trusted_Connection= True;"
                );
        }
    }
}
