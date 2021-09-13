using InterfaceMultiple.Rules;

namespace InterfaceMultiple.Employee
{
    public class Employees : IAgreement, ILeaves, ISalary, IShifts
    {
        public string agreement()
        {
            return "You have to serve 1 month notice period";
        }

        public int leaves()
        {
            return 15;
        }

        public int salary()
        {
            return 400000;
        }

        public int work()
        {
            return 9;
        }
    }
}