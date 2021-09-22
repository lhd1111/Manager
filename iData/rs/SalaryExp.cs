using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Text;

namespace iData.rs
{   
    [Table(nameof(SalaryExp))]
    public class SalaryExp:Base
    {
        public Person Person { get; set; }
        [MaxLength(10), Display(Name = "职务等级")]
        public string zwdj { get; set; }
        [MaxLength(10),Display(Name ="月薪或星级")]
        public string Money { get; set; }
        public DateTime StartDate { get; set; }
        public int DueMonth { get; set; } = 0;
        public DateTime? EndDate { get; set; }
        [Display(Name ="类型"),MaxLength(20)]
        public string Type { get; set; }
        public int iOrder { get; set; }
        public int requestid { get; set; }
        [Display(Name = "工号"), MaxLength(10)]
        public string gh { get; set; }
        [MaxLength(50)]
        public string Note { get; set; }
    }
}
