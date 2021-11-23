using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.rs
{
    [Table(nameof(BusSummary))]
    public class BusSummary:Base
    {
        [Display(Name ="工号"),MaxLength(10)]
        public string gh { get; set; }
        public string TableName { get; set; }
        public string TableId { get; set; }
        
    }
}
