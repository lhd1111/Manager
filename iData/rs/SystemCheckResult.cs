using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(SystemCheckResult))]
    public class SystemCheckResult : Base
    {
        [Display(Name ="人员id")]
        public int AccountId { get; set; }
        [Display(Name = "部门")]
        public int DepartmentId { get; set; }
        [Display(Name ="检查结果"),MaxLength(10)]
        public string CheckResult { get; set; }
        [Display(Name ="结果描述")]
        public string ResultDescription { get; set; }
        [Display(Name = "责任部门")]
        public string DepartmentStrs { get; set; }
        [Display(Name = "备注")]
        public string Remark { get; set; }
        [Display(Name = "检查条目")]
        public int SystemCheckId { get; set; }
        [Display(Name = "计划检查时间")]
        public DateTime? PlanDate { get; set; }
        [Display(Name = "实际完成时间")]
        public DateTime? ActualTime { get; set; }
        
    }
}
