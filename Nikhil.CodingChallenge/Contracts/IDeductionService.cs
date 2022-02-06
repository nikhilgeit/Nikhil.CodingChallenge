
using Nikhil.CodingChallenge.Models;
using Nikhil.CodingChallenge.ViewModels;

namespace Nikhil.CodingChallenge.Contracts
{
    public interface IDeductionService
    {
        decimal CalculateDeductionPerPaycheck(Employee employee);
        decimal CalculateDeductionPerYear(Employee employee);
    }
}
