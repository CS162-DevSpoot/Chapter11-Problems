namespace CS162_Chapter11_Problems.MonthClass
{
    enum Month {
        Janaury = 1, Febriary = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, September = 9, October = 10, November = 11, December = 12
    }
    internal class MonthClass
    {
        private Dictionary<int, string> month = new Dictionary<int, string>(){
            {1, "Janaury"}
        };
        public int MonthNumber {get; init;}
        public string MonthName {get; init;}

        public MonthClass(){
            MonthNumber =1;
            MonthName = (Month)1.ToString();
        }

        public MonthClass(int monthNumber){
            if(monthNumber < 1 || monthNumber > 12){
                MonthNumber = 1;
            }else{
                MonthNumber = monthNumber;
            }

            DateTime newDT = new DateTime(2024, MonthNumber, 1);
            MonthName = (Month)monthNumber.ToString();
        }

        public MonthClass(string monthName){
            MonthName = (Month)monthName.ToString();
        }

        public MonthClass(MonthClass monthClass){
            MonthName = monthClass.MonthName;
            MonthNumber = monthClass.MonthNumber;
        }

        public ToString(){
            return (Month)MonthNumber.ToString();
        }

        public IsGreaterThan(MonthClass monthClass){
            if(monthClass.MonthNumber < MonthNumber){
                return true;
            }else{
                return false;
            }
        }

        public IsLessThan(MonthClass monthClass){
            if(monthClass.MonthNumber > MonthNumber){
                return true;
            }else{
                return false;
            }
        }
    }
}
