using Newtonsoft.Json;
using StarPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarPractice.Services
{
    public class StarwarsFacade : IStarwarsFacade
    {
        private readonly IStarwarsService _starwarsService;

        public StarwarsFacade(IStarwarsService starwarsService)
        {
            _starwarsService = starwarsService;

        }

        public async Task<PeopleViewModel> GetAllPeople()
        {
            var results = await _starwarsService.SelectAllPeople();

            var peopleViewModel = new PeopleViewModel();
            peopleViewModel.People = new List<Person>();

            foreach (var responsePerson in results.Results)
            {
                var person = new Person();
                person.Name = responsePerson.Name;
                person.Url = responsePerson.Url;

                peopleViewModel.People.Add(person);
            }

            return peopleViewModel;
        }

        public async Task<PersonViewModel> SelectAPerson(string url)
        {
            var apiEnding = GetPersonInfo(url);
            var results = await _starwarsService.SelectAPerson(apiEnding);

            var personViewModel = new PersonViewModel
            {
                Height = results.Height,
                Created = results.Created,
                Mass = results.Mass,
                Edited = results.Edited,
                Films = results.Films,
                Hair_Color = results.Hair_Color,
                Name = results.Name,
                Skin_Color = results.Skin_Color,
                Eye_Color = results.Eye_Color,
                Birth_Year = results.Birth_Year,
                Gender = results.Gender,
                Homeworld = results.Homeworld,
                Species = results.Species,
                Vehicles = results.Vehicles,
                Starships = results.Starships,
                Url = results.Url
            };  

            return personViewModel;
        }

        private string GetPersonInfo(string url)
        {
            string[] separator = { "https://swapi.co" };
            int count = 1;

            string[] strlist = url.Split(separator, count, StringSplitOptions.RemoveEmptyEntries);

            return strlist[0];
        }
    }
}
