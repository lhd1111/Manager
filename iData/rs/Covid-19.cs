using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(Covid_19))]
    public class Covid_19:Base
    {
        [MaxLength(10)]
        public string gh { get; set; }
        public int VaccinateType { get; set; }
        public int Already { get; set; }
        public DateTime? rq { get; set; }
    }
}
