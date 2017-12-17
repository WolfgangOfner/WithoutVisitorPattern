namespace WithoutVisitorPattern
{
    public class Salary
    {
        public double SalaryBeforeTax { get; set; }

        public double SalaryAfterTax => SalaryBeforeTax * 0.8;
    }
}