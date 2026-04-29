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

        public double OvertimeFee = 0;

        public double ServiceCharge = 20;

        public double TotalFee = 0;
      
        public Reservation(string plateNumber, string vehicleType, double hoursParked, string assignedSlot)
        {
            PlateNumber = plateNumber;
            VehicleType = vehicleType;
            HoursParked = hoursParked;
            AssignedSlot = assignedSlot;
        }
        public double CalculateFee()
        {
            switch (VehicleType.ToLower())
            {
                case "car":
                    TotalFee = HoursParked * 50;
                    break;
                case "motorcycle":
                    TotalFee = HoursParked * 30;
                    break;
                case "van":
                    TotalFee = HoursParked * 70;
                    break;
                default:
                    return 0;
            }

            if (HoursParked > 8)
            {
                OvertimeFee = (HoursParked - 8) * 30;
            }

            return TotalFee + ServiceCharge + OvertimeFee ;
        }
    }
}
