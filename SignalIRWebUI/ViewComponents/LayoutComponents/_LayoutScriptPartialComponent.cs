using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIRWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutScriptPartialComponent:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();

        }

    }
}
