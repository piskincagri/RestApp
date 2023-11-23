using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIRWebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutNavBarComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
