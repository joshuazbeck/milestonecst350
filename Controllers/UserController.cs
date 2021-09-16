using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milestone.Controllers
{
    /**
     * Handle user CRUD operations such as registration and login
     * @TODO - Implement
     */
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
