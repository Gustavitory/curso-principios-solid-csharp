namespace OpenClose
{
    public class EmployeeContractor : IEmployee
    {
        public string FullName { get; set; }
        public int HoursWorked { get; set; }
        public EmployeeContractor(string fullname, int hoursWorked)
        {
            FullName = fullname;
            HoursWorked = hoursWorked;
        }
        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 15000M;
            decimal salary = hourValue * this.HoursWorked;
            return salary;
        }
    }
}