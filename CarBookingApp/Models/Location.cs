using System;
using System.Collections.Generic;
using System.Text;

namespace CarBookingApp.Models
{
    public class Location
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }

        public Location(int x, int y)
        {
            this.xCoordinate = x;
            this.yCoordinate = y;
        }
    }
}
