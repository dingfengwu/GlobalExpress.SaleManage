using GlobalExpress.SaleManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GlobalExpress.SaleManage.Controllers
{
    [RoutePrefix("api/Leader")]
    public class LeaderController : BaseApiController
    {
        [Route("LeaderList")]
        [HttpGet]
        public IHttpActionResult LeaderList()
        {
            return GridJson(new List<LeaderModel>()
            {
                new LeaderModel
                {
                    Name="测试线索1",
                    SourceName="电话",
                    VerifiedTypeName="未知",
                    CreateDate=DateTime.Now,
                    CreateEmplName="张三"
                },
                 new LeaderModel
                {
                    Name="测试线索3",
                    SourceName="电话",
                    VerifiedTypeName="未知",
                    CreateDate=DateTime.Now,
                    CreateEmplName="王五"
                },
                new LeaderModel
                {
                    Name="测试线索2",
                    SourceName="电话",
                    VerifiedTypeName="未知",
                    CreateDate=DateTime.Now,
                    CreateEmplName="李四"
                }
            });
        }
    }
}
