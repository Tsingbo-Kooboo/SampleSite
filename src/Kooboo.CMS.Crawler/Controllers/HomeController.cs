using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Kooboo.CMS.Content.Models;
using Kooboo.CMS.Content.Query;
using Kooboo.CMS.Sites.View;

namespace Kooboo.CMS.Crawler.Controllers
{
    public class HomeController : Web.Areas.Contents.Controllers.ControllerBase
    {
        public ActionResult Index(string folder)
        {
            return Content("Hello");
        }
    }
}
