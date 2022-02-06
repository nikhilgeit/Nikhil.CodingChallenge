using Nikhil.CodingChallenge.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nikhil.CodingChallenge.Models
{
    public class Dependent : Person
    {
        [Required]
        public DependentType Type { get; set; }
    }
}