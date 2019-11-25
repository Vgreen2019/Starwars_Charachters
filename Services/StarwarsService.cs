using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StarPractice.Models;

namespace StarPractice.Services
{
    public class StarwarsService : IStarwarsService
    {
        public async Task<StarWarsPeopleResponse> SelectAllPeople()
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://swapi.co") })   //We can use _baseUrl instead of the actual string 
            {

                var result = await httpClient.GetStringAsync("/api/people/");
                return JsonConvert.DeserializeObject<StarWarsPeopleResponse>(result);
            }
        }

        public async Task<StarWarsPersonResponse> SelectAPerson(string urlEndPoint)
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://swapi.co") })   //We can use _baseUrl instead of the actual string 
            {

                var result = await httpClient.GetStringAsync(urlEndPoint);
                return JsonConvert.DeserializeObject<StarWarsPersonResponse>(result);
            }
        }
    }
}
