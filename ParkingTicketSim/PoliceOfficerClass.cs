namespace CS162_Chapter11_Problems.ParkingTicketSim
{
    public class PoliceOfficerClass
    {
        public int BadgeNumber {get; init;}
        public string Name {get; init;}

        public PoliceOfficerClass(int badge, string name){
            BadgeNumber = badge;
            Name = name;
        }

        public double? examParkedCar(ParkedCarClass parkedCar, ParkingMeterClass meter){
            if(parkedCar.MinutesParked > meter.MinutesPaid){
                return 60.00/(parkedCar.MinutesParked-meter.MinutesPaid);
            }else{
                return null;
            }
        }

        public ParkingTicketClass issueTicket(ParkedCarClass parkedCar, double hoursOver){
            int fine = 25 + (int)(25*hoursOver);

            return new ParkingTicketClass(parkedCar.Make, parkedCar.Model, parkedCar.Color, parkedCar.LicensePlate, fine, BadgeNumber, Name);
        }
    }
}
