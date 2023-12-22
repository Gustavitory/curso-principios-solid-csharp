namespace OpenClose
{
    interface IEmployee
    {
        public string FullName { get; set; }
        public int HoursWorked { get; set; }
        public decimal CalculateSalaryMonthly();
    }
}