﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIRWebUI.ViewComponents.DefaultComponents
{
    public class _DefatultAboutComponentPartial: ViewComponent
    {

        public IViewComponentResult Invoke()

        {

            return View();
        }


    }
}
