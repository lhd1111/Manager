using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Marketing
{
    [Table(nameof(PricePacking))]
    public class PricePacking:Base
    {
        [Display(Name = "容器尺寸"), MaxLength(50)]
        public string ContainerSize { get; set; }
        [Display(Name = "容器成本"), Column(TypeName = "decimal(7, 4)")]
        public decimal ContainerCost { get; set; }
        [Display(Name = "容器"), MaxLength(50)]
        public string Container { get; set; }
        [Display(Name = "包装成本"), Column(TypeName = "decimal(7, 4)")]
        public decimal PackingCost { get; set; }
        [Display(Name = "运输费用"), Column(TypeName = "decimal(17, 4)")]
        public decimal TranportationCost { get; set; }
        [Display(Name = "运输费"), Column(TypeName = "decimal(7, 4)")]
        public decimal LogisticCost { get; set; }
        [Display(Name = "三方费"), Column(TypeName = "decimal(7, 4)")]
        public decimal StorageFee { get; set; }
        [Display(Name = "客服费"), Column(TypeName = "decimal(7, 4)")]
        public decimal AftersalesService { get; set; }
        [Display(Name = "其它费"), Column(TypeName = "decimal(7, 4)")]
        public decimal Others { get; set; }
        [Display(Name = "包装费"), Column(TypeName = "decimal(7, 4)")]
        public decimal bzfy { get; set; }
        [Display(Name ="包装类型"),MaxLength(20)]
        public int PackingId { get; set; }
        [Display(Name = "各种类型"), MaxLength(5)]
        public string DeptType { get; set; }
        [Display(Name = "折扣"), Column(TypeName = "decimal(5, 4)")]
        public decimal Discount1 { get; set; } = 1.0m;
        public int BomId { get; set; }
        public int PriceCollectionId { get; set; }

    }
}
