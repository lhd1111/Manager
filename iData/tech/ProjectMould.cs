using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.tech
{
    [Table(nameof(ProjectMould))]
    public class ProjectMould:Base
    {
        //等级
        public string LevelName { get; set; }
        //节点
        public string NodeName { get; set; }
        //描述
        public string Description { get; set; }
        //天数
        public int Days { get; set; }
    }
}
