using Dev_cardMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using Dev_cardMVC.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dev_cardMVC.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly List<Service> _s = new List<Service>
        {
            new Service(1,"gold"),
            new Service(1,"silver"),
            new Service(1,"bronze"),
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PDetails(int id)
        {
            var project = Projectstore.GetProjectBy(id);
            return View(project);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contactform 
            {
                Services = new SelectList(_s,"Id","Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contactform cf)
        {
            cf.Services = new SelectList(_s,"Id","Name");
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Not Send please check";
                return View(cf);
            }
            ModelState.Clear();
            cf = new Contactform
            {
                Services = new SelectList(_s, "Id", "Name")
            };
            ViewBag.Success = "Send Done";
            return View(cf);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
