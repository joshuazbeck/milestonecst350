using Microsoft.AspNetCore.Mvc;
using Milestone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Milestone.Controllers
{
    public class SavedGamesController : Controller
    {
        public IActionResult GameWith(int id)
        {
            var result = (new GameBoardAPI()).SavedGames(id).Value;

            return View("ShowGame", result);
        }
        public IActionResult Index()
        {
            var result = (new GameBoardAPI()).Index().Value;

            return View("Index", result);
        }
        public IActionResult DeleteGame(int id)
        {
            (new GameBoardAPI()).DeleteGame(id + 1);
            
            return View("Index", (new GameBoardAPI()).Index().Value);
        }
    }
}
