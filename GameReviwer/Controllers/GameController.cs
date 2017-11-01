using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameReviewer.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameReviewer.Controllers
{
    public class GameController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(Game.ReadAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            Game.Create(game);
            return RedirectToAction("Index");
        }
    }
}
