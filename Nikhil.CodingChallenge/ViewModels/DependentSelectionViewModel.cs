using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nikhil.CodingChallenge.ViewModels
{
    public class DependentSelectionViewModel
    {
        [Required]
        [Display(Name = "Select the number of dependents for the employee")]
        public int DependentsCount { get; set; }
    }
}