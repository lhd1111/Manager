using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(TravelReport))]
    public class TravelReport:Base
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Display(Name = "始发地")]
        public string ShiFa { get; set; }
        [Display(Name = "目的地")]
        public string MuDi { get; set; }
        [Display(Name ="途径省市")]
        public string TuJing { get; set; }
        [Display(Name ="同行人员")]
        public string TongXing { get; set; }
        [Display(Name ="出行工具")]
        //汽车、自驾、铁路、飞机
        public string GongJu { get; set; }

        [Display(Name ="航班信息")]
        public string HangBan { get; set; }
        [Display(Name ="gh"),MaxLength(10)]
        public string gh { get; set; }
    }
}
