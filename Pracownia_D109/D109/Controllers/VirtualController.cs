﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace D109.Controllers
{
    public class VirtualController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}