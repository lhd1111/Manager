using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(TrainExp))]
    public class TrainExp:Base
    {
        [Display(Name = "培训人")]
        public Person Person { get; set; }
        [Display(Name = "开始时间")]
        public DateTime StartDate { get; set; }
        [Display(Name = "结束时间")]
        public DateTime EndDate { get; set; }
        [Display(Name ="是否内培")]
        public bool IsInner { get; set; }
        [Display(Name ="培训讲师"), MaxLength(20)]
        public string Teacher { get; set; }
        [Display(Name ="证书"), MaxLength(20)]
        public string Certificate { get; set; }
    }
}
