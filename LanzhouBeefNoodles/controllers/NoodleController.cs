﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanzhouBeefNoodles.controllers
{
    public class NoodleController : Controller
    {
        // GET: /<controller>/
        public IList<string> Index()
        {
            return new List<string> { "牛肉面","羊肉面","鸡蛋面"};
        }
    }
}
