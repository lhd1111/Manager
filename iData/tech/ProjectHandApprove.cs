using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.tech
{
    [Table(nameof(ProjectHandApprove))]
    public class ProjectHandApprove:Base
    {
        [Column(TypeName = "decimal(5,2)")]
        public decimal Score { get; set; }
        public string Note { get; set; }
        public int? HandId { get; set; }
        public int TaskId { get; set; }
    }
}
