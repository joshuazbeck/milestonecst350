using Microsoft.AspNetCore.Mvc;
using Milestone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milestone.Controllers
{
    public class GameController : Controller
    {
        static List<CellModel> cells = new List<CellModel>();
        Random rand = new Random();
        static int GRID_SIZE = 36;
        public IActionResult Index()
        {
            cells = new List<CellModel>();

            for (int i = 0; i < GRID_SIZE; i++)
            {
                cells.Add(new CellModel(i, rand.Next(2)));
            }
            return View("Index", cells);
        }
    }
}
