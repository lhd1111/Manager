using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(Attendance))]
    public class Attendance:Base
    {
        [Display(Name ="打卡时间")]
        public DateTime CheckTime { get; set; }
        [Display(Name ="考勤属性"),MaxLength(2)]
        //字符d代表定
        public string CheckType { get; set; }
        [MaxLength(50)]
        public string gh { get; set; }
        [MaxLength(50),Display(Name ="原因")]
        public string Reason { get; set; }
        public bool IsPass { get; set; }
    }
}
