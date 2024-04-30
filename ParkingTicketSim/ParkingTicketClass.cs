namespace CS162_Chapter11_Problems.ParkingTicketSim
{
    public class ParkingTicketClass
    {
        public string Make {get; init;}
        public string Model {get; init;}
        public string Color {get; init;}
        public string LicensePlate {get; init;}

        public int Fine {get; init;}
        public int BadgeNumber {get; init;}
        public string OfficerName {get; init;}
        
        public ParkingTicketClass(ParkedCarClass parkedCar, int fine, PoliceOfficerClass LEO){
            Make = parkedCar.Make;
            Model = parkedCar.Model;
            Color = parkedCar.Color;
            LicensePlate = parkedCar.LicensePlate;
            Fine =  fine; 
            BadgeNumber = LEO.BadgeNumber;
            OfficerName = LEO.Name;
        }

    }
}
