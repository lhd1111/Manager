using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(CalendarKq))]
    public class CalendarKq:Base
    {
        public Frequency Frequency { get; set; }
        public DateTime CheckDate { get; set; }
        [Display(Name ="日历属性"),MaxLength(2)]
        public string DateProp { get; set; }
    }
}
