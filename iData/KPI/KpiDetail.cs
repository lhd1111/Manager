using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using iData.Marketing;

namespace iData.KPI
{
    [Table(nameof(KpiDetail))]
    public class KpiDetail:Base
    {
        [MaxLength(5)]
        public string iYear { get; set; }
        [Column(TypeName = "decimal(15, 4)")]
        public decimal iValue { get; set; } = 0;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal iFz { get; set; } = 0;

        [Column(TypeName = "decimal(15, 4)")]
        public decimal iFm { get; set; } = 0;

        public int iOrder { get; set; } = 0;
        public int EnumId { get; set; }
        public int KpiId { get; set; }


    }
}
