using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nikhil.CodingChallenge.ViewModels
{
    public class EmployeeDeductionViewModel
    {
        [Display(Name = "Employee Paycheck Deductions:")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal EmployePaycheckDeductions { get; set; }

        [Display(Name = "Employee Annual Deductions:")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal EmployeeAnnualDeductions { get; set; }

        [Display(Name = "Dependents Paycheck Deductions:")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal DependentPaycheckDeductions { get; set; }

        [Display(Name = "Dependents Annual Deductions:")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal DependentAnnualDeductions { get; set; }

        [Display(Name = "Paycheck After Deductions:")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal PayCheckAfterDeducations { get; set; }

        [Display(Name = "Paycheck Before Deductions:")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal PayCheckBeforeDeducations { get; set; }
        public bool HasDiscount { get; set; }
    }
}