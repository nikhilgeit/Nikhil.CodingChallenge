using Nikhil.CodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nikhil.CodingChallenge.Contracts
{
    public interface IDiscountService
    {
        decimal GetDiscount(Person person);
    }
}