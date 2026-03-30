using System.Linq;
using System.Web.Mvc;
using ItemProcessingApp.Models;

public class ItemController : Controller
{
    private ApplicationDbContext db = new ApplicationDbContext();

    // LIST ITEMS
    public ActionResult Index()
    {
        var items = db.Items.ToList();
        return View(items);
    }

    // CREATE ITEM
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Item item)
    {
        if (ModelState.IsValid)
        {
            db.Items.Add(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(item);
    }

    // EDIT ITEM
    public ActionResult Edit(int id)
    {
        var item = db.Items.Find(id);
        return View(item);
    }

    [HttpPost]
    public ActionResult Edit(Item item)
    {
        if (ModelState.IsValid)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(item);
    }

    // DELETE ITEM
    public ActionResult Delete(int id)
    {
        var item = db.Items.Find(id);
        db.Items.Remove(item);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    // PROCESS ITEM (ADD CHILD ITEMS)
    public ActionResult Process(int id)
    {
        ViewBag.ParentId = id;
        return View();
    }

    [HttpPost]
    public ActionResult Process(int parentId, string childName, double weight)
    {
        var child = new Item
        {
            ItemName = childName,
            Weight = weight,
            ParentItemId = parentId,
            IsProcessed = false
        };

        db.Items.Add(child);

        var parent = db.Items.Find(parentId);
        parent.IsProcessed = true;

        db.SaveChanges();

        return RedirectToAction("Index");
    }

    // TREE VIEW
    public ActionResult TreeView()
    {
        var items = db.Items.ToList();
        return View(items);
    }
}
