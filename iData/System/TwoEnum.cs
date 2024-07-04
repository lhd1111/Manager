using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.System
{
    [Table(nameof(TwoEnum))]
    public class TwoEnum:TreeBase<TwoEnum>
    {
        //总类型，隔离各个区域
        public string Type { get; set; }
        [Display(Name = "英文名"), MaxLength(20)]
        public string EName { get; set; }
        [Display(Name = "值"), MaxLength(20)]
        public string Value { get; set; }
        public int iOrder { get; set; }
        public bool IsDel { get; set; } = false;
        public int DepartmentId { get; set; }

    }
}
