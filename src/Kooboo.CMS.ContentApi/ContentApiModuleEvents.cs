using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Kooboo.CMS.Sites.Extension.ModuleArea;
using Kooboo.CMS.Sites.Extension.ModuleArea.Management;

namespace Kooboo.CMS.ContentApi
{
    public class ContentApiModuleEvents:IModuleEvents
    {
        public void OnInstalling(ModuleContext moduleContext, ControllerContext controllerContext)
        {
        }

        public void OnUninstalling(ModuleContext moduleContext, ControllerContext controllerContext)
        {
        }

        public void OnIncluded(ModuleContext moduleContext)
        {
        }

        public void OnExcluded(ModuleContext moduleContext)
        {
        }

        public void OnReinstalling(ModuleContext moduleContext, ControllerContext controllerContext,
            InstallationContext installationContext)
        {
        }
    }
}
