using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting.Web.Mvc;

namespace LuahelpPastebin.Controllers
{
    public class PasteController : Controller
    {
        [GET("/")]
        public ActionResult New()
        {
            return View();
        }

    }
}
