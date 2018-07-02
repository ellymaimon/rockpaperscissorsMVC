using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/results-page")]
        public ActionResult Results()
        {
            Game newGame = new Game();
            newGame.SetPlayerOne(Request.Query["playerone"]);
            newGame.SetPlayerTwo(Request.Query["playertwo"]);
            return View(newGame);
        }

    }
}
