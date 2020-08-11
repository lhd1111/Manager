using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cg
{
    [Table("MaterialSplitCost")]
    public class MaterialSplitCost : Base
    {
        public string U8Code{get;set;}
        public int MaxCount { get; set; }
        public float MouldCost { get; set; }
        public float CheckCost { get; set; }
        public float TestCost { get; set; }
        public float Price { get; set; }
        public string VendorName { get; set; }
        public bool IsConfirm { get; set; } = false;
    }
}
