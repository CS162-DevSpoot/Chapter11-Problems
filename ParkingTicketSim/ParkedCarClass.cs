namespace CS162_Chapter11_Problems.ParkingTicketSim
{
    internal class ParkedCarClass
    {
        public string Make {get; init;}
        public string Model {get; init;}
        public string Color {get; init;}
        public string LicensePlate {get; init;}
        public int MinutesParked {get; init;}

        public ParkedCarClass(string make, string model, string color, string lp, int minsParked){
            Make = make;
            Model = model;
            Color = color;
            LicensePlate = lp;
            MinutesParked = minsParked;
        }
    }
}
