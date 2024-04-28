namespace CS162_Chapter11_Problems.CarInstrumentSim
{
    internal class OdemterClass
    {
        private int Mileage = 0;

        public int updateMileage(){
            if(Mileage == 999999){
                Mileage = 0;
                return 0;
            }else{
                Mileage += 1;
                return Mileage;
            }
        }

        public int getCurrentMileage(){
            return Mileage;
        }
    }
}
