using System.Collections.Generic;
using Dev_cardMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dev_cardMVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                new Project(1,"Project1","Discription of project 1" ,"project-1.jpg","Pedram"),
                new Project(2,"Project2","Discription of project 2" ,"project-2.jpg","Pedram"),
                new Project(3,"Project3","Discription of project 3" ,"project-3.jpg","Pedram"),
                new Project(4,"Project4","Discription of project 4" ,"project-4.jpg","Pedram")

            };
            return View("_Project",projects);
        }
    }
}
