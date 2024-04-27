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

        public int consumeFuel(){
            if(FuelLevel > 0){
                FuelLevel -= 1;
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
