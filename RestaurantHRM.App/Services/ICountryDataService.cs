﻿using RestaurantHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantHRM.App.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
