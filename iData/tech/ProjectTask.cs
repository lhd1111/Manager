using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.tech
{
    [Table(nameof(ProjectTask))]
    public class ProjectTask : TreeBase<ProjectTask>
    {
        public bool IsHand { get; set; } = false;
        public bool IsNa { get; set; }
        [Display(Name = "进度"), Column(TypeName = "decimal(5,2)")]
        public decimal progress { get; set; }
        public string progressByWorklog { get; set; }
        public string relevance { get; set; }
        public string type { get; set; }
        public string typeId { get; set; }
        public string description { get; set; }
        //暂时放置阶段属性,此处放置责任人更好
        //public string code { get; set; }
        [Display(Name = "状态"), MaxLength(13)]
        public string status { get; set; }
        [Display(Name = "上级节点")]
        public string depends { get; set; }
        [Display(Name = "折叠")]
        public bool canWrite { get; set; }
        public bool canNa { get; set; } = true;
        public DateTime PlanStartDate { get; set; }
        public DateTime PlanEndDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        //出于灵活性考虑，此处另行计算
        public int duration { get; set; }
        [Display(Name = "里程碑")]
        public bool startIsMilestone { get; set; }
        [Display(Name = "里程碑")]
        public bool endIsMilestone { get; set; }
        [Display(Name = "折叠")]
        public bool collapsed { get; set; }
        public bool hasChild { get; set; }
        [Display(Name="阶段属性"),MaxLength(20)]
        public string stage { get; set; }
        [Display(Name = "责任部门"), MaxLength(20)]
        public string responsibility { get; set; }
        [Display(Name = "责任人"), MaxLength(20)]
        public string PersonName { get; set; }
        [Display(Name = "工号"), MaxLength(10)]
        public string gh { get; set; }
        [Display(Name = "排序号")]
        public int iOrder { get; set; }
        public int ProjectId { get; set; }

    }
}
