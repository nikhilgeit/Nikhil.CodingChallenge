using Nikhil.CodingChallenge.Handlers;
using Nikhil.CodingChallenge.Helpers;
using Nikhil.CodingChallenge.Models;
using Nikhil.CodingChallenge.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nikhil.CodingChallenge.Controllers
{
    public class HomeController : Controller
    {
        [CustomExceptionHandler]
        public ActionResult Index()
        {
            var model = new DependentSelectionViewModel();
            return View("DependentSelection", model);
        }

        [HttpPost]
        [CustomExceptionHandler]
        public ActionResult Index(DependentSelectionViewModel model)
        {
            if (ModelState.IsValid && model !=null)
            {
                var employee = new Employee();
                for (int i = 0; i < model.DependentsCount; i++)
                {
                    employee.Dependents.Add(new Dependent());
                }
                return View(employee);
            }
            return View("DependentSelection", new DependentSelectionViewModel());
        }
    }
}