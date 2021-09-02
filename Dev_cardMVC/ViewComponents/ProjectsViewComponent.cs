using Dev_cardMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace Dev_cardMVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = Projectstore.GetProjects();
            return View("_Project",projects);
        }
    }
}
