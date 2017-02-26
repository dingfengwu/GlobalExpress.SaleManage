using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalExpress.SaleManage.Models
{
    public class LeaderModel
    {
        /// <summary>
        /// 线索名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 来源名称
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        /// 验证类型
        /// </summary>
        public string VerifiedTypeName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 创建人名字
        /// </summary>
        public string CreateEmplName { get; set; }
    }
}