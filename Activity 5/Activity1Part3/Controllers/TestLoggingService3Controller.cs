using Activity1Part3.Services.Business;
using Activity1Part3.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService3Controller : Controller
    {
        private readonly ILogger logger;
        private readonly ITestService service;

        public TestLoggingService3Controller()
        {
            this.logger = null;
            this.service = null;
        }

        public TestLoggingService3Controller(ILogger log, ITestService service)
        {
            this.logger = log;
            this.service = service;
        }

        public string Index()
        {
            logger.Info("controller 3 log");
            service.TestLogger();
            return "controller 3 test";
        }
    }
}