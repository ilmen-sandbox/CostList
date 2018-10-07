namespace CostList.Controllers
{
    using CostList.Models;
    using System;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private readonly CostContext db = new CostContext();

        public ActionResult Index()
        {
            ViewBag.Costs = db.Costs.ToList();
            return View();
        }
        
        [HttpPost]
        public ActionResult AddCost(Cost cost)
        {
            if (cost.Date == null) cost.Date = DateTime.Now;

            db.Costs.Add(cost);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}