using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace iData.Marketing
{
    [Table(nameof(PriceCollection))]
    public class PriceCollection:TreeBase<PriceCollection>
    {
        public int Ver { get; set; }
        public string Note { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        //考虑到随时，因此不设实际开始日期，根据实际结束日期判定
        public DateTime? ActualEndDate { get; set; }
        public bool IsClose { get; set; }
        //报价状态，已退回，默认接受报价
        [MaxLength(10)]
        public string PriceStatus { get; set; }
        public int iOrder { get; set; }
        [Display(Name = "责任人"), MaxLength(20)]
        public string PersonName { get; set; }
        //考虑到人员的部门调动，此处记录部门
        [Display(Name = "责任人部门"), MaxLength(20)]
        public string DepartmentName { get; set; }
        [Display(Name = "责任人工号"), MaxLength(20)]
        public string PersonGh { get; set; }
        [Display(Name = "报价链接"), MaxLength(20)]
        public string UrlPath { get; set; }
        public int requestId { get; set; }
        [Display(Name = "折扣"), Column(TypeName = "decimal(5, 4)")]
        public decimal Discount { get; set; } = 1.0m;
        //邮件发送的依赖关系
        [Display(Name = "单项总计"), Column(TypeName = "decimal(10, 2)")]
        public decimal Total { get; set; } = 0;
        //邮件发送的依赖关系
        public int mailId { get; set; }
        public int resetTimes { get; set; } = 0;

    }
}
