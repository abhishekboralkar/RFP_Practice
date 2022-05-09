namespace PracticeProblem1
{
    public class Program
    {
        public int EmpPresent = 1;
        public int Emphr = 8;
        public int PartTime = 1;
        public int WagesPerHour = 20;
        public int FullTimeEmp= 1;
        public void CheckEmpPresentAbsent()
        {
            Random Check = new Random();
            int CheckEmp = Check.Next(0, 2);

            if (EmpPresent == CheckEmp)
            {
                Console.WriteLine("Employee is Present");
                Random Timecheck = new Random();
                int checkTimeEmp = Timecheck.Next(0, 2);
                if (FullTimeEmp == checkTimeEmp)
                {
                    int DailyWagePerHr = Emphr * WagesPerHour;
                    Console.WriteLine("Dailywages" + DailyWagePerHr);
                }

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
        public static void Main(string[] args)

        {
            Program prg = new Program();
            prg.CheckEmpPresentAbsent();

        }
    }
}
