using System;
using System.Collections.Generic;
using System.Text;

namespace CarBookingApp.Models
{
    public class Cab
    {
        public IVehicle vehicle { get; set; }
        public Driver driver { get; set; }
        public Location currentLocation { get; set; }

        public Cab(IVehicle vehicle, string driverName, Location currLocation)
        {
            this.vehicle = vehicle;
            driver = new Driver(driverName);
            currentLocation = currLocation;            
        }

        public void UpdateLocation(Location newLocation)
        {
            this.currentLocation = newLocation;
        }
    }
}
