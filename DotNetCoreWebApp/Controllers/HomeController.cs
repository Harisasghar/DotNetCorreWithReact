using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private static List<CommentModel> _comments;

        public HomeController()
        {
            _comments = new List<CommentModel>
            {
                new CommentModel
                {
                    Id = 1,
                    Author = "Daniel Lo Nigro",
                    Text = "Hello ReactJS.NET World!"
                },
                new CommentModel
                {
                    Id = 2,
                    Author = "Pete Hunt",
                    Text = "This is one comment"
                },
                new CommentModel
                {
                    Id = 3,
                    Author = "Jordan Walker",
                    Text = "This is *another* comment. Multiple comments."
                },
            };
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("comments")] // attribute routing
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)] // no caching
        public ActionResult Comments()
        {
            return Json(_comments);
        }

    }
}
