using Nikhil.CodingChallenge.Contracts;
using Nikhil.CodingChallenge.Models;

namespace Nikhil.CodingChallenge.Services
{
    public class DiscountService : IDiscountService
    {
        public decimal GetDiscount(Person person)
        {
            if (person != null && !string.IsNullOrEmpty(person.Name))
            {
                return person.Name.ToUpper().StartsWith("A") ? Constants.DiscountRate : 0;
            }
            else
            {
                return 0;
            }
        }
    }
}