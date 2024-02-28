using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Marketing
{
    [Table(nameof(PriceCostDetail))]
    public class PriceCostDetail:Base
    {
        [MaxLength(5)]
        public string iYear { get; set; }
        [Column(TypeName = "decimal(15, 4)")]
        public decimal iValue { get; set; } = 0;
        public int iOrder { get; set; } = 0;
        public int EnumId { get; set; }
        public int PriceCollectionId { get; set; }

    }
}
