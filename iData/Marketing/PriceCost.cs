using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Marketing
{
    [Table(nameof(PriceCost))]
    public class PriceCost:Base
    {
        public float iTotal { get; set; }
        public string Note { get; set; }
        public string DeptType { get; set; } = "成本";
        public int EnumId { get; set; }
        public int PriceCollectionId { get; set; }
    }
}
