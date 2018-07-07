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

            model.designPatterns.Add(new Models.DesignPattern() { Name = "Adapter", Category = Models.Category.Structural });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Bridge", Category = Models.Category.Creational });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Builder", Category = Models.Category.Creational });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "ChainOfResponsibility", Category = Models.Category.Behavioral });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Command", Category = Models.Category.Behavioral });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Composite", Category = Models.Category.Structural });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Decorator", Category = Models.Category.Structural });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Strategy", Category = Models.Category.Behavioral });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Facade", Category = Models.Category.Structural });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Factory", Category = Models.Category.Creational });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Flyweight", Category = Models.Category.Structural });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Interpreter", Category = Models.Category.Behavioral });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Iterator", Category = Models.Category.Behavioral });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Mediator", Category = Models.Category.Behavioral });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Momento", Category = Models.Category.Behavioral });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Observer", Category = Models.Category.Behavioral });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Prototype", Category = Models.Category.Creational });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Proxy", Category = Models.Category.Structural });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Singleton", Category = Models.Category.Creational });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "State", Category = Models.Category.Behavioral });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Strategy", Category = Models.Category.Behavioral });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Template", Category = Models.Category.Behavioral });
            model.designPatterns.Add(new Models.DesignPattern() { Name = "Visitor", Category = Models.Category.Behavioral });

            return View(model);
        }
    }
}