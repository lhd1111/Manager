using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace iData.Marketing
{
    [Table(nameof(PriceCheck))]
    public class PriceCheck:Base
    {
        public string CheckName { get; set; }
        public int CheckNumber { get; set; }
        public decimal CheckCost { get; set; }
        [Display(Name = "各种类型"), MaxLength(5)]
        public string DeptType { get; set; }
        public int BomId { get; set; }
        public int PriceCollectionId { get; set; }
    }
}
