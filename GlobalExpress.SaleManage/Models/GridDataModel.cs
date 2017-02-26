using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalExpress.SaleManage.Models
{
    public class GridDataModel<TModel> where TModel : new()
    {
        public int draw { get; set; }

        public int recordsTotal { get; set; }

        public int recordsFiltered { get; set; }

        public IEnumerable<TModel> data { get; set; }
    }
}