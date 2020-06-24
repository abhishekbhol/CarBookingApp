using System;
using System.Collections.Generic;
using System.Text;

namespace CarBookingApp.Models
{
    public interface IVehicle
    {
        public string vehicleName { get; }
        public string vehicleNumber { get; set; }
        public int passengerLimit { get; }
        public int currentPassengerNumber { get; set; }
        public bool isVehicleOccupied();
        public bool dropPassengers();
        public bool boardPassenger();
    }
}
