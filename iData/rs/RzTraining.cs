using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(RzTraining))]
    public class RzTraining:Base
    {
        public string Title { get; set; }
        public int Ver { get; set; }
        public string Description { get; set; }
        [MaxLength(50)]
        public string Note { get; set; }
        [MaxLength(10)]
        public string Type { get; set; }
        [MaxLength(10)]
        public string gh { get; set; }
        public bool IsDel { get; set; } = false;
        public bool IsPrt { get; set; } = false;
        public int iOrder { get; set; } = 1;
    }
}
