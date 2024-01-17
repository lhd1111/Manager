using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.tech
{
    [Table(nameof(ProjectHand))]
    public class ProjectHand:Base
    {
        //手顺名称
        [MaxLength(50)]
        public string Name { get; set; }
        [Display(Name = "阶段属性"), MaxLength(20)]
        public string stage { get; set; }
        [Display(Name = "责任部门"), MaxLength(20)]
        public string responsibility { get; set; }
        //任务节点名称
        [MaxLength(50)]
        public string TaskName { get; set; }
        //手顺等级，1●；2◎；3○
        public int HandKind { get; set; }
        //允许关联模板的task
        public int ProjectTask { get; set; }

    }
}
