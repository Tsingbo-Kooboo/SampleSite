using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Kooboo.CMS.Common;
using Kooboo.Web.Mvc;

namespace Kooboo.CMS.ContentApi
{
    public class ApiAreaRegistration : AreaRegistrationEx
    {
        public const string Name = "Api";
        public override string AreaName => Name;

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(Name + "_default", Name + "/{controller}/{action}/{id}",
                new { controller = "textcontent", action = "index", id = UrlParameter.Optional }, null,
                new[]
                {"Kooboo.CMS.ContentApi.Controllers", "Kooboo.Web.Mvc", "Kooboo.Web.Mvc.WebResourceLoader"});

            Kooboo.Web.Mvc.Menu.MenuFactory.RegisterAreaMenu(AreaName, AreaHelpers.CombineAreaFilePhysicalPath(AreaName, "Menu.config"));
            base.RegisterArea(context);
        }
    }
}
