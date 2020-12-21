﻿using Activity1Part3.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService2Controller : Controller
    {
        [Dependency]
        public ILogger logger { get; set; }

        // GET: TestLoggingService2
        [CustomAuthorization]
        public string Index()
        {
            logger.Info("test string");
            return "returning a string";
        }
    }
}