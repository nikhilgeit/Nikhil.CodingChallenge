using Nikhil.CodingChallenge;
using Nikhil.CodingChallenge.Contracts;
using Nikhil.CodingChallenge.Models;
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
        public decimal CalculateDeductionPerPaycheck(Employee employee)
        {
            return CalculateDeductionPerYear(employee) / Constants.YearlyPayChecksCount;
        }

        public decimal CalculateDeductionPerYear(Employee employee)
        {
            var employeeAnnualDeduction = Constants.EmployeeAnnualDeduction * (1 - _discountService.GetDiscount(employee));
            if (employee.Dependents.Any())
            {
                foreach (var dependent in employee.Dependents)
                {
                    employeeAnnualDeduction += Constants.DependentAnnualDeduction * (1 - _discountService.GetDiscount(dependent));
                }
            }
            return employeeAnnualDeduction;
        }

    }
}
