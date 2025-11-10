using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.tech
{
    [Table(nameof(ProjectList))]
    public class ProjectList : Base
    {
        [Display(Name = "项目名称"), MaxLength(50)]
        public string ProjectName { get; set; }
        [Display(Name = "项目编号"), MaxLength(50)]
        public string Code { get; set; }
        [Display(Name = "车型"), MaxLength(50)]
        public string CarType { get; set; }
        [Display(Name = "所属科室"), MaxLength(50)]
        public string NavForeign { get; set; }
        [Display(Name = "项目经理"), MaxLength(20)]
        public string PersonName { get; set; }
        [Display(Name = "工号"), MaxLength(20)]
        public string gh { get; set; }
        [Display(Name = "营销经理"), MaxLength(20)]
        public string MarketName { get; set; }
        [Display(Name = "工号"), MaxLength(20)]
        public string MarketGh { get; set; }
        [Display(Name = "开发部门"), MaxLength(20)]
        public string Development { get; set; }
        [Display(Name = "设计科经理"), MaxLength(20)]
        public string Design { get; set; }
        [Display(Name = "版本信息")]
        public int Ver { get; set; } = 1;
        [Display(Name = "开发等级"),MaxLength(1)]
        public string DevelopLevel { get; set; } 
        [Display(Name ="客户名称"),MaxLength(50)]
        public string CustomerName { get; set; }
        [Display(Name = "投产地点"), MaxLength(50)]
        public string InvestAddr { get; set; }
        [Display(Name = "量纲"), MaxLength(50)]
        public string Dimensional { get; set; }
        [Display(Name = "投产日期"), MaxLength(50)]
        public DateTime InvestDate { get; set; }
        public bool canWrite { get; set; } = true;
        public bool canWriteOnParent { get; set; } = true;
        public string changesReasonWhy { get; set; } 
        //public int tasks { get; set; }
        [Display(Name = "缩放状态"), MaxLength(10)]
        public string zoom { get; set; }
        [Display(Name = "描述"), MaxLength(50)]
        public string Reason { get; set; }
        [Display(Name = "关闭原因"), MaxLength(10)]
        public string CloseStatus { get; set; }
        [Display(Name = "关闭"), MaxLength(10)]
        public bool IsClose { get; set; }
        public DateTime PlanStartDate { get; set; }
        public DateTime PlanEndDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        //模板期限，0为没有允许不填
        public string? ProjectMould { get; set; }
    }
}
