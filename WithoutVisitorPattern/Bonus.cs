namespace WithoutVisitorPattern
{
    public class Bonus
    {
        public double Revenue { get; set; }

        public double BonusBeforeTax => Revenue * 0.05;

        public double BonusAfterTax => BonusBeforeTax + 0.8;
    }
}