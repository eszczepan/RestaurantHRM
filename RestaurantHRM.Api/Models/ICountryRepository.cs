using RestaurantHRM.Shared;
using System.Collections.Generic;

namespace RestaurantHRM.Api.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}
