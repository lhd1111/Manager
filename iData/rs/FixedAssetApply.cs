using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.rs
{
    [Table(nameof(FixedAssetApply))]
    public class FixedAssetApply : Base
    {
        public DateTime StartDate{get;set;}
        public DateTime EndDate { get; set; }
        [Display(Name = "部门id")]
        public int DepartmentId { get; set; }
        [Display(Name = "姓名"), MaxLength(20)]
        public string PersonName { get; set; }
        [Display(Name = "工号"), MaxLength(20)]
        public string gh { get; set; }
        public int FixedAssetId { get; set; }

    }
}
