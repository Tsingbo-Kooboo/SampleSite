using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Kooboo.CMS.ContentApi.Controllers
{
    public class TextContentController : Kooboo.CMS.Web.Areas.Contents.Controllers.ControllerBase
    {
        public JsonResult List(string id)
        {
            return Json(new { hello = "world" }, JsonRequestBehavior.AllowGet);
        }
    }
}
