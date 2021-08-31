using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev_cardMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dev_cardMVC.ViewComponents
{
    public class BlogsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var blogs = new List<Blog>()
            {
                new Blog(1, "TextTitle1", "description 1", "blog-post-thumb-1.jpg"),
                new Blog(2, "TextTitle2", "description 2", "blog-post-thumb-2.jpg"),
                new Blog(3, "TextTitle3", "description 3", "blog-post-thumb-3.jpg"),
            };
            return View("_Blog",blogs);
        }

    }
}
