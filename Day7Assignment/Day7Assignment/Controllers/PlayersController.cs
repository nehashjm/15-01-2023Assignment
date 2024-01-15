using Day7Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day7Assignment.Controllers
{
    public class PlayersController : Controller
    {
        static List<Player> players = new List<Player>()
        {
            new Player(){PId=1,PName="Virat",PCountry="Bharat",PType="Bat" },
            new Player(){PId=2,PName="Rohit",PCountry="Bharat",PType="Bat"},
            new Player(){PId=3,PName="Jasprit",PCountry="Bharat",PType="Bowl"}
        };
        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create(Player play)
        {
            if(ModelState.IsValid)
            {
                players.Add(play);
            }
            return View();
        }
    }
}
