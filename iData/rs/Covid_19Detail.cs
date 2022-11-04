using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(Covid_19Detail))]
    public class Covid_19Detail:Base
    {
        public int ReportId { get; set; }
        [MaxLength(20)]
        public string gh { get; set; }
        public string img { get; set; }
    }
}
