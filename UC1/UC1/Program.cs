namespace PracticeProblem1
{
    public class Program
    {
        public int EmpPresent = 1;
        public void CheckEmpPresentAbsent()
        {
            Random Check = new Random();
            int CheckEmp = Check.Next(0, 2);

            if (EmpPresent == CheckEmp)
            {
                Console.WriteLine("Employee is Present");
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