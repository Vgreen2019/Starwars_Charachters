using Microsoft.AspNetCore.Mvc;
using StarPractice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarPractice.Controllers
{
    public class StarwarsController: Controller
    {
        private readonly IStarwarsFacade _starwarsFacade;

        public StarwarsController(IStarwarsFacade starwarsFacade)
        {
            _starwarsFacade = starwarsFacade;

        }

        public async Task<IActionResult> ViewAll()
        {
            var result = await _starwarsFacade.GetAllPeople();
            return View(result);
        }

        public async Task<IActionResult> ViewAPerson(string url)
        {
            var result = await _starwarsFacade.SelectAPerson(url);
            return View(result);
        }

    }
}
