using Nikhil.CodingChallenge.Contracts;
using Nikhil.CodingChallenge.Handlers;
using Nikhil.CodingChallenge.Models;
using Nikhil.CodingChallenge.ViewModels;
using System.Web.Mvc;

namespace Nikhil.CodingChallenge.Controllers
{
    public class DeductionResultsController : Controller
    {
        private readonly IDeductionService _deductionService;
        public  DeductionResultsController(IDeductionService deductionService)
        {
            _deductionService = deductionService;
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [CustomExceptionHandler]
        public ActionResult Index(Employee model)
        {
            var employeeDeductionViewModel = new EmployeeDeductionViewModel();
            if (ModelState.IsValid && model !=null)
            {
                employeeDeductionViewModel.PayCheckBeforeDeducations = model.PayCheckAmount;
                employeeDeductionViewModel.EmployePaycheckDeductions = _deductionService.CalculateEmployeePaycheckDeductions(model);
                employeeDeductionViewModel.EmployeeAnnualDeductions = _deductionService.CalculateEmployeeAnnualDeductions(model);
                employeeDeductionViewModel.DependentAnnualDeductions = _deductionService.CalculateDependentsAnnualDeductions(model?.Dependents);
                employeeDeductionViewModel.DependentPaycheckDeductions = _deductionService.CalculateDependentsPaycheckDeductions(model?.Dependents);
                var totalDeductions = employeeDeductionViewModel.EmployePaycheckDeductions + employeeDeductionViewModel.DependentPaycheckDeductions;
                employeeDeductionViewModel.PayCheckAfterDeducations = model.PayCheckAmount - totalDeductions;
            }
            return View(employeeDeductionViewModel);
        }
    }
}