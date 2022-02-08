
using Nikhil.CodingChallenge.Models;
using Nikhil.CodingChallenge.ViewModels;
using System.Collections.Generic;

namespace Nikhil.CodingChallenge.Contracts
{
    public interface IDeductionService
    {
        decimal CalculateEmployeePaycheckDeductions(Employee employee);
        decimal CalculateEmployeeAnnualDeductions(Employee employee);
        decimal CalculateDependentsPaycheckDeductions(List<Dependent> dependents);
        decimal CalculateDependentsAnnualDeductions(List<Dependent> dependents);
    }
}
