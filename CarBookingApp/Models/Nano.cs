using System;
using System.Collections.Generic;
using System.Text;

namespace CarBookingApp.Models
{
    public class Nano : IVehicle
    {
        public string vehicleName { get => "Nano"; }
        public int passengerLimit { get => 1; }
        public int currentPassengerNumber { get; set; }
        public string vehicleNumber { get; set; }

        public Nano(string vehicleNumber)
        {
            this.vehicleNumber = vehicleNumber;
        }

        public bool boardPassenger()
        {
            if(isVehicleOccupied())
            {
                return false;
            }
            this.currentPassengerNumber = passengerLimit;
            return true;
        }

        public bool dropPassengers()
        {
            if (!isVehicleOccupied())
            {
                return false;
            }
            this.currentPassengerNumber = 0;
            return true;
        }

        public bool isVehicleOccupied()
        {
            return this.currentPassengerNumber != 0;
        }
    }
}
