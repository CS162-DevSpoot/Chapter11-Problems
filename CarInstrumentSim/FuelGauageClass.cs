namespace CS162_Chapter11_Problems.CarInstrumentSim
{
    internal class FuelGauageClass
    {
        private double FuelLevel = 0;
        public double FuelMaxLevel {get; init;}

        public FuelGauageClass(double maxLevel){
            FuelLevel = maxLevel;
            FuelMaxLevel = maxLevel;
        }

        public double consumeFuel(double milesDriven){
            if(FuelLevel > 0){
                FuelLevel -= milesDriven/24.00;
                return FuelLevel;
            }else{
                FuelLevel = 0;
                return 0;
            }
            
        }

        public void refuel()
        {
            if(FuelLevel == FuelMaxLevel)
            {
                return;
            }

            if((FuelLevel + 1) > 15)
            {
                FuelLevel = 15;
                return;
            }

            FuelLevel += 1;
        }

        public double getFuelLevels(){
            return FuelLevel;
        }
    }
}
