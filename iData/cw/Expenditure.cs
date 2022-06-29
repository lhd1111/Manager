using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cw
{
    [Table(nameof(Expenditure))]
    public class Expenditure:Base
    {
        //public string Name { get; set; }
        //public string Description { get; set; }
        [Display(Name = "工号"), MaxLength(10)]
        public string gh { get;set; }
        public DateTime CalendarDate { get; set; }
        //public string DateProp { get; set; }
        [Display(Name = "时长"), Column(TypeName = "decimal(8, 2)")]
        public decimal WorkHour { get;set;}
        public int ProjectListId { get;set;}
    }
}
