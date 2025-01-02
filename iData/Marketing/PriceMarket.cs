using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace iData.Marketing
{
    [Table(nameof(PriceMarket))]
    public class PriceMarket:Base
    {
        [Column(TypeName = "decimal(10, 3)")]
        public decimal PriceCost { get; set; }
        [Column(TypeName = "decimal(10, 3)")]
        public decimal PriceNumber { get; set; }
        [Column(TypeName = "decimal(15, 4)")]
        public decimal PriceSum { get; set; }
        [Display(Name = "备注")]
        public string Note { get; set; }
        [Display(Name = "各种类型"), MaxLength(5)]
        public string DeptType { get; set; }
        [Display(Name = "行合计"), Column(TypeName = "decimal(12, 4)")]
        public decimal RowSummary { get; set; } = 0;

        public int BomId { get; set; } = 0;

        public int EnumId { get; set; }
        public int PriceCollectionId { get; set; }

    }
}
