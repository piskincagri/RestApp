﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIRWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultBookATableComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }


    }
}
