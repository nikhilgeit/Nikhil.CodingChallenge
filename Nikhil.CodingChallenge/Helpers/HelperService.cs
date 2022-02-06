using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nikhil.CodingChallenge.Helpers
{
    public static class HelperService
    {
        public static List<SelectListItem> GetDependentTypeList()
        {
            var dependentTypesList = new List<SelectListItem>();
            foreach (var value in Enum.GetValues(typeof(DependentType)))
            {
                dependentTypesList.Add(new SelectListItem() { Text = value.ToString(), Value = value.ToString() });
            }
            return dependentTypesList;
        }

        public static List<SelectListItem> GetDependentSelectionList()
        {
            var dependentSelectionList = new List<SelectListItem>();
            for (var i = 0; i <= Constants.MaximumDependentsAllowed; i++)
            {
                var selectionItem = new SelectListItem() { Value = i.ToString() };
                selectionItem.Text = i == 0 ? "No Dependent" : (i == 1 ? $"{i} Dependent" : $"{i} Dependents") ;
                dependentSelectionList.Add(selectionItem);
            }
            return dependentSelectionList;
        }

    }
}