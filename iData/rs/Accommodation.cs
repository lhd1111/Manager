using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(Accommodation))]
    public class Accommodation : Base
    {
        [Display(Name ="入住日期")]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Display(Name = "房屋来源"), MaxLength(50)]
        public int SusheId { get;set;}
        [MaxLength(10)]
        public string gh { get; set; }

    }
}
