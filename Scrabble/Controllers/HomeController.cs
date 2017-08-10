using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;

namespace Scrabble.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/scrabble/score")]
        public ActionResult Score()
        {
            ScrabbleGame newScore = new ScrabbleGame(Request.Form["userWord"]);
            int Score = newScore.GetScore();
            return View(Score);
        }
    }
}
