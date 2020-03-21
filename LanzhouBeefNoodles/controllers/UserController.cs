﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LanzhouBeefNoodles.controllers
{
    [Route("admin/[controller]/[action]")]
    public class UserController : Controller
    {
        public IList<string> Index()
        {
            return new List<string> { "阿莱克斯","莱克斯","克斯","斯"};
        }
    }
}