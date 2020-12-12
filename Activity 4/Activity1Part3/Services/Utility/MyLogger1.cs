using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity1Part3.Services.Utility
{
    public class MyLogger1
    {
        private static MyLogger1 instance;
        private static Logger logger;


        private MyLogger1()
        {

        }

        public static MyLogger1 GetInstance()
        {
            if (instance == null)
            {
                instance = new MyLogger1();
            }
            return instance;
        }

        public void Debug(string message, string arg = null)
        {
            if (arg == null)
            {
                GetInstance("myAppLoggerRules").Debug(message);
            }
            else
            {
                GetInstance("myAppLoggerRules").Debug(message, arg);
            }
        }

        public void Error(string message, string arg = null)
        {
            if (arg == null)
            {
                GetInstance("myAppLoggerRules").Debug(message);
            }
            else
            {
                GetInstance("myAppLoggerRules").Debug(message, arg);
            }
        }
        public void Error(string message, bool isValid)
        {
            if (isValid)
            {
                GetInstance("myAppLoggerRules").Debug(message);
            }
            else
            {
                GetInstance("myAppLoggerRules").Debug(message, isValid);
            }
        }

        public void Info(string message, string arg = null)
        {
            if (arg == null)
            {
                GetInstance("myAppLoggerRules").Debug(message);
            }
            else
            {
                GetInstance("myAppLoggerRules").Debug(message, arg);
            }
        }

        public void Warning(string message, string arg = null)
        {
            if (arg == null)
            {
                GetInstance("myAppLoggerRules").Debug(message);
            }
            else
            {
                GetInstance("myAppLoggerRules").Debug(message, arg);
            }
        }
        private Logger GetInstance(string thelogger)
        {
            if (MyLogger1.logger == null)
            {
                MyLogger1.logger = LogManager.GetLogger(thelogger);
            }
            return MyLogger1.logger;
        }
    }
}