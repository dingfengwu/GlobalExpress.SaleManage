using GlobalExpress.SaleManage.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace GlobalExpress.SaleManage.Controllers
{
    public class BaseApiController : ApiController
    {
        protected IHttpActionResult GridJson<TModel>(IEnumerable<TModel> data) where TModel:new()
        {
            return Json(new GridDataModel<TModel>() {
                draw = 1,
                recordsFiltered = data.Count(),
                recordsTotal = data.Count(),
                data = data
            });
        }
    }
}
