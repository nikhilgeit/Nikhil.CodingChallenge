using Nikhil.CodingChallenge;
using Nikhil.CodingChallenge.Contracts;
using Nikhil.CodingChallenge.Models;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.BusinessLayer.Services
{
    public class DeductionService : IDeductionService
    {
        private readonly IDiscountService _discountService;

        public DeductionService(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        public decimal CalculateEmployeePaycheckDeductions(Employee employee)
        {
            return CalculateEmployeeAnnualDeductions(employee) / Constants.YearlyPayChecksCount;
        }

        public decimal CalculateEmployeeAnnualDeductions(Employee employee)
        {
            var employeeDiscount = Constants.EmployeeAnnualDeduction * _discountService.GetDiscount(employee);
            return Constants.EmployeeAnnualDeduction - employeeDiscount;
        }

        public decimal CalculateDependentsPaycheckDeductions(List<Dependent> dependents)
        {
            return CalculateDependentsAnnualDeductions(dependents) / Constants.YearlyPayChecksCount;
        }

        public decimal CalculateDependentsAnnualDeductions(List<Dependent> dependents)
        {
            if (dependents.Any())
            {
                var dependentsDiscount = 0m;
                if (dependents.Any())
                {
                    foreach (var dependent in dependents)
                    {
                        dependentsDiscount += Constants.DependentAnnualDeduction * _discountService.GetDiscount(dependent);
                    }
                }
                return Constants.DependentAnnualDeduction - dependentsDiscount;
            }
            else
            {
                return 0;
            }
        }
    }
}
