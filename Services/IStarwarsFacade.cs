using StarPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarPractice.Services
{
    public interface IStarwarsFacade
    {
        Task<PeopleViewModel> GetAllPeople();

        Task<PersonViewModel> SelectAPerson(string url);
    }
}
