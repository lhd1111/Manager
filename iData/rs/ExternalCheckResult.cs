using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(ExternalCheckResult))]
    public class ExternalCheckResult:Base
    {
        [Display(Name = "问题类别"), MaxLength(2)]
        public string ProblemType { get; set; }
        [Display(Name = "问题描述")]
        public string Description { get; set; }
        [Display(Name = "原因分析")]
        public string Analysis { get; set; }
        [Display(Name = "改善对策")]
        public string Solution { get; set; }
        [Display(Name = "关联文件")]
        public string SystemCheckName { get; set; }
        [Display(Name = "关键点")]
        public string KeyPoint { get; set; }
        [Display(Name = "责任部门")]
        public string DepartmentStrs { get; set; }
        [Display(Name = "责任部门长")]
        public string UserName { get; set; }
        [Display(Name = "是否关闭"), MaxLength(1)]
        public string IsClosed { get; set; }
        [Display(Name = "外部检查id")]
        public int ExternalCheckId { get; set; }
    }
}
