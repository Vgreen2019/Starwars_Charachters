using StarPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarPractice.Services
{
    public interface IStarwarsService
    {
        Task<StarWarsPeopleResponse> SelectAllPeople();
        Task<StarWarsPersonResponse> SelectAPerson(string url);
    }
}
