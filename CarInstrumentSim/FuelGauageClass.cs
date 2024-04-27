namespace CS162_Chapter11_Problems.CarInstrumentSim
{
    internal class FuelGauageClass
    {
        private int FuelLevel = 0;
        public int FuelMaxLevel {get; init;}

        public FuelGauageClass(int maxLevel){
            FuelLevel = maxLevel;
            FuelMaxLevel = maxLevel;
        }

        public int consumeFuel(decimal milesDriven){
            if(FuelLevel > 0){
                FuelLevel -= milesDriven/24;
                return FuelLevel;
            }else{
                FuelLevel = 0;
                return 0;
            }
            
        }

        public int getFuelLevels(){
            return FuelLevel;
        }
    }
}
