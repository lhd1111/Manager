using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.KPI
{
    [Table(nameof(KpiMain))]
    public class KpiMain:Base
    {
        public int EnumId { get; set; }
        public string EnumStr { get; set; }
        public string EnumPStr { get; set; }
        public string Method { get; set; }
        public string Note { get; set; }
        public int DepartmentId { get; set; }
        [Column(TypeName = "decimal(15, 4)")]
        public decimal bz { get; set; }

        public int iYear { get; set; }
        [Column(TypeName = "decimal(15, 4)")]
        public decimal iTotal { get; set; } = decimal.Zero;

        [Column(TypeName = "decimal(15, 4)")]
        public decimal M_01 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal M_02 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal M_03 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal Q_01 { get; set; }=decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal M_04 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal M_05 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal M_06 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal Q_02 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal M_07 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")] 
        public decimal M_08 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")] 
        public decimal M_09 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")] 
        public decimal Q_03 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")] 
        public decimal M_10 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")] 
        public decimal M_11 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")] 
        public decimal M_12 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")] 
        public decimal Q_04 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal iTotalFz { get; set; } = decimal.Zero;

        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzM_01 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzM_02 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzM_03 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzQ_01 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzM_04 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzM_05 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzM_06 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzQ_02 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzM_07 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzM_08 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzM_09 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzQ_03 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzM_10 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzM_11 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzM_12 { get; set; } = decimal.Zero;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FzQ_04 { get; set; } = decimal.Zero;

        [Column(TypeName = "decimal(15, 4)")]
        public decimal iTotalFm { get; set; } = 1.0m;

        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmM_01 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmM_02 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmM_03 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmQ_01 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmM_04 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmM_05 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmM_06 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmQ_02 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmM_07 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmM_08 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmM_09 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmQ_03 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmM_10 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmM_11 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmM_12 { get; set; } = 1.0m;
        [Column(TypeName = "decimal(15, 4)")]
        public decimal FmQ_04 { get; set; } = 1.0m;

    }
}
