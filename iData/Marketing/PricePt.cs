using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Marketing
{
    [Table(nameof(PricePt))]
    public class PricePt:Base
    {
        [Column(TypeName = "decimal(10, 4)")]
        public decimal PtSum { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal PtCost { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public decimal PtNumber { get; set; }
        [MaxLength(20)]
        public string PtName { get; set; }
        [Display(Name ="涂装备注")]
        public string PtNote { get; set; }
        [MaxLength(20)]
        public string PtType { get; set; }
        public int iOrder { get; set; }
        public int EnumId { get; set; }
        public int BomId { get; set; }
        public int PriceDeptId { get; set; }
        public int PriceCollectionId { get; set; }
    }
}
