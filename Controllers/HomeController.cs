using System.Web.Mvc;
using ItemProcessingApp.Models;
using System.Collections.Generic;

namespace ItemProcessingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var items = new List<Item>
            {
                new Item { Id = 1, Name = "Item1", Price = 100 },
                new Item { Id = 2, Name = "Item2", Price = 200 }
            };

            return View(items);
        }
    }
}