using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nikhil.CodingChallenge.ViewModels
{
    public class EmployeeDeductionViewModel
    {
        [Display(Name = "Deduction Per Paycheck :")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal DeductionPerPaycheck { get; set; }
        [Display(Name = "Deduction Per Year :")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal DeductionPerAnum { get; set; }
    }
}