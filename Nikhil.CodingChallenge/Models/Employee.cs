using System;
using System.Collections.Generic;
using Nikhil.CodingChallenge;

namespace Nikhil.CodingChallenge.Models
{
    public class Employee : Person
    {
        public int PayCheckSalary { get; set; } = Constants.SalaryPerPayCheck;
        public List<Dependent> Dependents { get; set; } = new List<Dependent>();
    }
}