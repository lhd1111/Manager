using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(Repair))]
    public class Repair:Base
    {
        [MaxLength(50)]
        public string ssmc { get; set; }
        [MaxLength(50)]
        public string sswz { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}
