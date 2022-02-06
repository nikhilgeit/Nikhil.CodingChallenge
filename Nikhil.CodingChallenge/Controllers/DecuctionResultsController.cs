using Nikhil.CodingChallenge.Contracts;
using Nikhil.CodingChallenge.Models;
using Nikhil.CodingChallenge.ViewModels;
using System.Web.Mvc;

namespace Nikhil.CodingChallenge.Controllers
{
    public class DecuctionResultsController : Controller
    {
        private readonly IDeductionService _deductionService;
        public  DecuctionResultsController(IDeductionService deductionService)
        {
            _deductionService = deductionService;
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Employee model)
        {
            var employeeDeductionViewModel = new EmployeeDeductionViewModel();
            if (ModelState.IsValid && model !=null)
            {
                employeeDeductionViewModel.DeductionPerPaycheck = _deductionService.CalculateDeductionPerPaycheck(model);
                employeeDeductionViewModel.DeductionPerAnum = _deductionService.CalculateDeductionPerYear(model);
            }
            return View(employeeDeductionViewModel);
        }
    }
}