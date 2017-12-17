using System;

namespace WithoutVisitorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person = new Person("Wolfgang", 28);
            person.Slaray.Add(new Salary {SalaryBeforeTax = 10000});
            person.Slaray.Add(new Salary {SalaryBeforeTax = 300});
            person.Bonus.Add(new Bonus {Revenue = 30000});
            person.Marketing.Add(new Marketing {MarketingCosts = 5000});

            var totalSalary = 0.0;

            foreach (var item in person.Slaray)
            {
                totalSalary += item.SalaryAfterTax;
            }

            foreach (var item in person.Bonus)
            {
                totalSalary += item.BonusAfterTax;
            }

            foreach (var item in person.Marketing)
            {
                totalSalary -= item.MarketingCosts;
            }

            Console.WriteLine($"The total salary of {person.Name} is {totalSalary}");

            Console.ReadLine();
        }
    }
}