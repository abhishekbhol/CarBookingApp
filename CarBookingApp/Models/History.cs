using System;
using System.Collections.Generic;
using System.Text;

namespace CarBookingApp.Models
{
    public class History
    {
        public List<Ride> rides { get; set; }

        public History()
        {
            this.rides = new List<Ride>();
        }

        public void AddRide(Ride r)
        {
            this.rides.Add(r);
        }
    }

    public class Ride
    {
        public Guid driverId { get; set; }
        public Guid vehicleId { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public Location startLocation { get; set; }
        public Location endLocation { get; set; }
    }
}
