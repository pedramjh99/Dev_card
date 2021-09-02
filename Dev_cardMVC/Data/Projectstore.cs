using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev_cardMVC.Models;

namespace Dev_cardMVC.Data
{
    public class Projectstore
    { 
        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project(1, "Project1", "Discription of project 1", "project-1.jpg", "Pedram"),
                new Project(2, "Project2", "Discription of project 2", "project-2.jpg", "Pedram"),
                new Project(3, "Project3", "Discription of project 3", "project-3.jpg", "Pedram"),
                new Project(4, "Project4", "Discription of project 4", "project-4.jpg", "Pedram"),
            };
        }

        public static Project  GetProjectBy(int id)
        {
            return GetProjects().FirstOrDefault(x => x.Id == id);
        }
    }
}
