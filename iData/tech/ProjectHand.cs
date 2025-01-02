using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.tech
{
    [Table(nameof(ProjectHand))]
    public class ProjectHand:TreeBase<ProjectHand>
    {
        public int MainNumber { get; set; } = 0;
        public int HandNumber { get; set; } = 0;
        //主日程名称
        [MaxLength(100)]
        public string Alias { get; set; }
        [Display(Name = "阶段属性"), MaxLength(20)]
        public string stage { get; set; }
        [Display(Name = "责任部门"), MaxLength(20)]
        public string responsibility { get; set; }
        //任务节点名称
        //[MaxLength(50)]
        //public string TaskName { get; set; }
        //手顺等级，1●；2◎；3○
        public int HandKind { get; set; } = 0;
        //点检要点
        [MaxLength(100)]
        public string KeyPoint { get; set; }
        public string Pd5 { get; set; }

        public string Pd4 { get; set; }

        public string Pd3 { get; set; }

        public string Pd2 { get; set; }

        public string Pd0 { get; set; }
        public bool canNa { get; set; } = false;

        public int iOrder { get; set; }
        //允许关联模板的task,projectId=3,考虑到一对多的情况，以、分隔
        public string ProjectTask { get; set; }
        public string Note { get; set; }
        public string ProjectTaskId { get; set; } = "0";


    }
}
