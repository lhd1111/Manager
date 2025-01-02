using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.tech
{
    [Table(nameof(ProjectPoint))]
    public class ProjectPoint:Base
    {
        //一级
        //[MaxLength(2)]
        //public string PointLevel { get; set; }
        //提出日期
        //public DateTime StartDate { get; set; }
        //public string PersonName { get; set; }
        //public string PersonDepartment { get; set; }
        //public DateTime PlanEndDate { get; set; }
        //public DateTime? ActualEndDate { get; set; }
        public string Description { get; set; }
        //分析
        //public string Analysis { get; set; }
        //public string TempScenario { get; set; }
        //public string Scenario { get; set; }
        //public string HeadGh { get; set; }
        //public string HeadDepartment { get; set; }
        [MaxLength(5)]
        public string Status { get; set; }
        public int iOrder { get;set;  }
        public int ProjectTaskId { get; set; }
    }
}
