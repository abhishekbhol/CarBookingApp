using System;
using System.Collections.Generic;
using System.Text;

namespace CarBookingApp.Models
{
    public class Rider
    {
        public Guid identifier { get; set; }
        public string name { get; set; }
        public string overallRating { get; set; } // future functionality
        public History rideHistory { get; set; }

        public Rider(string name)
        {
            this.identifier = Guid.NewGuid();
            this.name = name;
            this.rideHistory = new History();
        }

    }
}
