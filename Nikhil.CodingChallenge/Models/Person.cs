using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nikhil.CodingChallenge.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }
    }
}