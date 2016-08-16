using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Kooboo.CMS.Common;
using Kooboo.Web.Mvc;

namespace Kooboo.CMS.Crawler
{
    public class CrawlerAreaRegistration : AreaRegistrationEx
    {
        public const string Name = "Crawler";
        public override string AreaName => Name;

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute("Crawler_default", Name + "/{controller}/{action}",
                new {controller = "home", action = "index"}, null,
                new[]
                {"Kooboo.CMS.Crawler.Controllers", "Kooboo.Web.Mvc", "Kooboo.Web.Mvc.WebResourceLoader"});
            Kooboo.Web.Mvc.Menu.MenuFactory.RegisterAreaMenu(AreaName, AreaHelpers.CombineAreaFilePhysicalPath(AreaName, "Menu.config"));
            Kooboo.Web.Mvc.WebResourceLoader.ConfigurationManager.RegisterSection(AreaName, AreaHelpers.CombineAreaFilePhysicalPath(AreaName, "WebResources.config"));

            base.RegisterArea(context);
        }
    }
}
