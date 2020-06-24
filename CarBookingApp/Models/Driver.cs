using System;
using System.Collections.Generic;
using System.Text;

namespace CarBookingApp.Models
{
    public class Driver
    {
        public Guid identifier { get; set; }
        public string name { get; set; }
        public string overallRating { get; set; } // future functionality
        public History rideHistory { get; set; }

        public Driver(string name)
        {
            this.identifier = Guid.NewGuid();
            this.name = name;
            this.rideHistory = new History();
        }
    }
}
