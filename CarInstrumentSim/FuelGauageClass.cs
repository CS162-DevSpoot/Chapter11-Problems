namespace CS162_Chapter11_Problems.CarInstrumentSim
{
    internal class FuelGauageClass
    {
        private int FuelLevel = 0;
        private int FuelMaxLevel {get; init;}

        public FuelGauageClass(int maxLevel){
            FuelLevel = maxLevel;
            FuelMaxLevel = maxLevel;
        }

        public void consumeFuel(){
            FuelLevel -= 1;
        }
    }
}
