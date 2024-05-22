using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace iData.Marketing
{
    [Table(nameof(WgYcl))]
    public class WgYcl : Base
    {

        //客户指定改模具费用
        public int ModelCg { get; set; }
        [MaxLength(100)]
        public string SupplierName{get;set;}
        [Display(Name = "单价"), Column(TypeName = "decimal(10, 4)")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "运费"), Column(TypeName = "decimal(10, 4)")]
        public decimal Transport { get; set; }
        [Display(Name = "币种"), MaxLength(5)]
        public string UnitType { get; set; }
        [Display(Name = "开机损耗率"), Column(TypeName = "decimal(10, 4)")]
        public decimal ScrapRate { get; set; }

        [Display(Name = "各种类型"), MaxLength(5)]
        public string DeptType { get; set; }
        [Display(Name = "汇率"), Column(TypeName = "decimal(3, 2)")]
        public decimal ExchangeRate { get; set; } = 1;
        [Display(Name = "关税"), Column(TypeName = "decimal(3, 2)")]
        public decimal Tariff { get; set; } = 1;
        [Display(Name = "配比"), Column(TypeName = "decimal(6, 2)")]
        public decimal Matching { get; set; } = 0;
        [Display(Name = "备注")]
        public string CgNote { get; set; }
        [Display(Name = "行合计"), Column(TypeName = "decimal(12, 4)")]
        public decimal RowSummary { get; set; } = 0;

        public int BomId { get; set; }
        public int PriceCollectionId { get; set; }
    }
}
