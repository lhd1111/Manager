using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.System
{
    [Table(nameof(ApproveRequest))]
    public class ApproveRequest:Base
    {
        //0：请求，1：同意，2：否决
        public int ApproveStatus { get; set; } = 0;
        public DateTime? ApproveTime { get; set; }
        public string ApproveName { get; set; }
        public string ApproveGh { get; set; }
        [Display(Name = "备注")]
        public string Note { get; set; }
        [Display(Name = "所属类(表名)")]
        public string Type { get; set; }

        public int TypeId { get; set; }

    }
}
