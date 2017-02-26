using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalExpress.SaleManage.Controllers
{
    public class BaseController:Controller
    {
        protected ActionResult CustomView()
        {
            var part = ControllerContext.HttpContext.Request["part"];

            if (part=="1")
            {
                return PartialView();
            }
            else
            {
                return View();
            }
        }
    }
}