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
        [MaxLength(5)]
        public string Status { get; set; }
        public string Description { get; set; }
        public int iOrder { get;set;  }
        public int ProjectTaskId { get; set; }
    }
}
