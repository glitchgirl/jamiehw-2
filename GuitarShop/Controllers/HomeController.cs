using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using GuitarShop.Models;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {

        private QuestionBoardContext context { get; set; }

        public HomeController(QuestionBoardContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List", "Home");
        }
        //list route controller/id/id2
        [Route("[Controller]s/{id?}/{id2?}")]
        public IActionResult List(string id = "All", string id2 = "All")
        {
            List<Question> fAQs = context.Questions.OrderBy(f => f.Id).ToList();
 
            return View(fAQs);
        }
    }
}