using CarBookingApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBookingApp.Controllers
{
    public class CabController
    {
        public static List<Rider> globalRiders { get; set; }
        public static List<Cab> globalCabs { get; set; }
    }
}
