﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(Frequency))]
    public class Frequency:Base
    {
        [Display(Name ="考勤名称")]
        public string Name { get; set; }
        [Display(Name ="简称"),MaxLength(2)]
        public string ShortName { get; set; }
        //[Display(Name ="起效日期")]
        //public DateTime StartDate { get; set; }
        //[Display(Name = "结束日期")]
        //public DateTime? EndDate { get; set; }
        [Display(Name ="午餐间隔")]
        public int Interval { get; set; }
        [Display(Name = "上班时间")]
        public DateTime StartTime { get; set; }
        [Display(Name = "下班时间")]
        public DateTime EndTime { get; set; }
        [Display(Name ="半班时间")]
        public int HalfWork { get; set; }
        [Display(Name = "晚餐时长")]
        public int Dinner { get; set; }

        [Display(Name = "是否加班"),MaxLength(2)]
        public string IsOvertime { get; set; }
        [Display(Name = "是否迟到"), MaxLength(2)]
        public string IsCdZt { get; set; }
        [Display(Name = "加班限定")]
        public int MaxOvertime { get; set; }
        [Display(Name = "部门id")]
        public int DepartmentId { get; set; }
        [Display(Name ="软删除")]
        public bool IsDel { get; set; }
        [Display(Name = "排序")]
        public int iOrder { get; set; }
        public virtual ICollection<CalendarKq> CalendarKqs { get; set; } = new List<CalendarKq>();

    }
}
