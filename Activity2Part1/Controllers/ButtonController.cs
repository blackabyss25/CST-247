using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class ButtonController : Controller
    {
        static List<ButtonModel> buttons = new List<ButtonModel>();
        // GET: Button
        public ActionResult ButtonIndex()
        {
            ButtonModel buttonOne = new ButtonModel(true);
            ButtonModel buttonTwo = new ButtonModel(false);
            buttons.Add(buttonOne);
            buttons.Add(buttonTwo);
            return View("Button", buttons);
        }

        public ActionResult onButtonClick(string button)
        {
            if (button == "1")
            {
                buttons[0].State = !buttons[0].State;
            }

            if (button == "2")
            {
                buttons[1].State = !buttons[1].State;
            }

            return View("Button", buttons);
        }

    }
}