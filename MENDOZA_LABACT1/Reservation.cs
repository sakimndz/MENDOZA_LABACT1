using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENDOZA_LABACT1
{
    public class Reservation
    {
        public string PlateNumber { get; set; }
        public string VehicleType { get; set; }
        public double HoursParked { get; set; }
        public string AssignedSlot { get; set; }

        public double Fee = 0;
      
        public Reservation(string plateNumber, string vehicleType, double hoursParked, string assignedSlot)
        {
            PlateNumber = plateNumber;
            VehicleType = vehicleType;
            HoursParked = hoursParked;
            AssignedSlot = assignedSlot;
        }
        public double CalculateFee()
        {
            double service_charge = 20;
            switch (VehicleType.ToLower())
            {
                case "car":
                    Fee = HoursParked * 50;
                    break;
                case "motorcycle":
                    Fee = HoursParked * 30;
                    break;
                case "van":
                    Fee = HoursParked * 70;
                    break;
                default:
                    return 0;
            }
            return Fee + service_charge;
        }
    }
}
