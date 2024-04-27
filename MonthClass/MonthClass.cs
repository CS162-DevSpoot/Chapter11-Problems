namespace CS162_Chapter11_Problems.MonthClass
{
    internal class MonthClass
    {
        private Dictionary<int, string> month = new Dictionary<int, string>(){
            {1, "Janaury"}
        };
        public int MonthNumber {get; init;}
        public string MonthName {get; init;}

        public MonthClass(){
            MonthNumber = 1;
        }

        public MonthClass(int monthNumber){
            if(monthNumber < 1 || monthNumber > 12){
                MonthNumber = 1;
            }else{
                MonthNumber = monthNumber;
            }

            DateTime newDT = new DateTime(2024, 1, 1);
            MonthName = newDT.ToString("m");
        }
    }
}
