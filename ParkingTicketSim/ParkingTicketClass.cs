namespace CS162_Chapter11_Problems.ParkingTicketSim
{
    internal class ParkingTicketClass
    {
        public string Make {get; init;}
        public string Model {get; init;}
        public string Color {get; init;}
        public string LicensePlate {get; init;}

        public int Fine {get; init;}
        public int BadgeNumber {get; init;}
        public int OfficerName {get; init;}
        
        public ParkingTicketClass(string make, string model, string color, string lp, int fine, int badgeNumber, string officerName){
            Make = make;
            Model = model;
            Color = color;
            LicensePlate = lp;
            Fine =  fine; 
            BadgeNumber = badgeNumber;
            OfficerName = officerName;
        }

    }
}
