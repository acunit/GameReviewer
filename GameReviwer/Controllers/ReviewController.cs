using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameReviewer.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameReviewer.Controllers
{
    public class ReviewController : Controller
    {
        [HttpGet]
        public IActionResult Create(string gameName)
        {
            ViewData["Game"] = gameName;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Review review, string gameName)
        {
            var game = Game.Read(gameName);
            game.AddReviewToGame(review);
            return RedirectToAction("Index", "Game");
        }
    }
}
