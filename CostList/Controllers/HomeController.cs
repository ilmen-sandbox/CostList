namespace CostList.Controllers
{
    using CostList.Models;
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public static List<Cost> CostDbSet { get; set; } = new List<Cost>
        {
            new Cost { Id = 1, Date = DateTime.Now, Description = "Cost 1", Amount = 100 },
            new Cost { Id = 2, Date = DateTime.Now.AddDays(-1), Description = "Cost 2", Amount = 20 }
        };

        public ActionResult Index()
        {
            ViewBag.Costs = CostDbSet;
            return View();
        }

        [HttpPost]
        public ActionResult AddCost(Cost cost)
        {
            if (cost.Date == null) cost.Date = DateTime.Now;

            CostDbSet.Add(cost);

            return RedirectToAction(nameof(Index));
        }
    }
}