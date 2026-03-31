using System.Web.Mvc;
using ItemProcessingApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ItemProcessingApp.Controllers
{
    public class HomeController : Controller
    {
        // Fake in-memory DB
        static List<Item> items = new List<Item>();

        public ActionResult Index()
        {
            return View(items);
        }

        // Add Item
        [HttpPost]
        public ActionResult Add(string name, double weight)
        {
            items.Add(new Item
            {
                Id = items.Count + 1,
                Name = name,
                Weight = weight,
                Children = new List<Item>()
            });

            return RedirectToAction("Index");
        }

        // Process Item → add child
        [HttpPost]
        public ActionResult Process(int parentId, string childName, double childWeight)
        {
            var parent = items.FirstOrDefault(x => x.Id == parentId);

            if (parent != null)
            {
                var child = new Item
                {
                    Id = items.Count + 1,
                    Name = childName,
                    Weight = childWeight,
                    ParentId = parentId,
                    Children = new List<Item>()
                };

                parent.Children.Add(child);
                items.Add(child);
            }

            return RedirectToAction("Index");
        }
    }
}
