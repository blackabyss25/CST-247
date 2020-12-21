using Activity1Part3.Services.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService1Controller : Controller
    {

        private readonly ILogger logger;

        // GET: TestLoggingService1
        [CustomAuthorization]
        public string Index()
        {
            logger.Info("testing logger 1");
            return "tested logger 1";
        }

        public TestLoggingService1Controller(ILogger log)
        {
            this.logger = log;
        }



    }
}