using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoringMVCDesignPatterns.Controllers
{
    public class DesignPatternsController : Controller
    {
        // GET: DesignPatterns
        public ActionResult Index()
        {
            var model = new BoringMVCDesignPatterns.Models.DesignPatternList();
            //This is where we would get the data from a database. Just mocking it up here.
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Strategy", Category = Models.Category.Behavioral });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Factory", Category = Models.Category.Unknown });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Adapter", Category = Models.Category.Unknown });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Decorator", Category = Models.Category.Unknown });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Singleton", Category = Models.Category.Unknown });
            return View(model);
        }
    }
}