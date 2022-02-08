using System.Collections.Generic;

namespace Nikhil.CodingChallenge.Models
{
    public class Employee : Person
    {
        public int PayCheckAmount { get; set; } = Constants.PayCheckAmount;
        public int PayChecksPerYear { get; set; } = Constants.YearlyPayChecksCount;
        public List<Dependent> Dependents { get; set; } = new List<Dependent>();
    }
}