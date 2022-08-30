using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.tech
{
    [Table(nameof(ProjectProblem))]
    public class ProjectProblem:TreeBase<ProjectProblem>
    {
        //问题状态(待回复、待实施、已延期、已关闭）
        [MaxLength(5)]
        public string Status { get; set; }
        [Display(Name = "项目名称"), MaxLength(50)]
        public string ProjectName { get; set; }
        [Display(Name = "项目编号"), MaxLength(50)]
        public string Code { get; set; }
        [Display(Name = "车型"), MaxLength(50)]
        public string CarType { get; set; }
        //流程编号
        public int requestid { get; set; }
        //方案描述
        public string Description { get; set; }
        [Display(Name = "责任部门"), MaxLength(20)]
        public string responsibility { get; set; }
        [Display(Name = "责任人"), MaxLength(20)]
        public string PersonName { get; set; }
        [Display(Name = "工号"), MaxLength(10)]
        public string gh { get; set; }
        [Display(Name = "提交人工号"), MaxLength(10)]
        public string SubmitGh { get; set; }
        //计划关闭日期
        public DateTime? PlanDate { get; set; }
        //实际关闭日期
        public DateTime? CloseDate { get; set; }

    }
}
