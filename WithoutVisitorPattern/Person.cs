using System.Collections.Generic;

namespace WithoutVisitorPattern
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Slaray = new List<Salary>();
            Bonus = new List<Bonus>();
            Marketing = new List<Marketing>();
        }

        public string Name { get; }

        public int Age { get; }

        public List<Salary> Slaray { get; set; }

        public List<Bonus> Bonus { get; set; }

        public List<Marketing> Marketing { get; set; }
    }
}