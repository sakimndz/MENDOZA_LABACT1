using System;

namespace MENDOZA_LABACT1
{
    public class Reservation
    {
        public string PlateNumber { get; set; }
        public string VehicleType { get; set; }
        public double HoursParked { get; set; }
        public string AssignedSlot { get; set; }

        public double StandardFee { get; private set; }
        public double OvertimeFee { get; private set; }
        public double ServiceCharge { get; private set; } = 20;
        public double TotalFee { get; private set; }

        public Reservation(string plateNumber, string vehicleType, double hoursParked, string assignedSlot)
        {
            PlateNumber = plateNumber;
            VehicleType = vehicleType;
            HoursParked = hoursParked;
            AssignedSlot = assignedSlot;
        }

        public double CalculateFee()
        {
            OvertimeFee = 0;
            StandardFee = 0;

            double ratePerHour;
            switch (VehicleType.ToLower())
            {
                case "car": ratePerHour = 50; break;
                case "motorcycle": ratePerHour = 30; break;
                case "van": ratePerHour = 70; break;
                default:
                    TotalFee = 0;
                    return 0;
            }

            double billableHours = Math.Min(HoursParked, 8);
            StandardFee = billableHours * ratePerHour;

            if (HoursParked > 8)
            {
                OvertimeFee = (HoursParked - 8) * 30;
            }

            TotalFee = StandardFee + ServiceCharge + OvertimeFee;
            return TotalFee;
        }
    }
}