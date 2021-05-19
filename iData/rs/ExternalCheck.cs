using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(ExternalCheck))]
    public class ExternalCheck:Base
    {
        [Display(Name ="审核日期")]
        public DateTime CheckDate { get; set; }
        [Display(Name ="客户名称"),MaxLength(50)]
        public string Customer { get; set; }
        [Display(Name ="项目名称"),MaxLength(50)]
        public string Project { get; set; }
        [Display(Name = "单位信息"), MaxLength(50)]
        public string DepartmentId { get; set; }
        [Display(Name = "是否关闭"), MaxLength(1)]
        public string IsClosed { get; set; }
    }
}
