using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace iData.Marketing
{
    [Table(nameof(PriceSelling))]
    public class PriceSelling: Base
    {
        //单车用量
        [Column(TypeName = "decimal(15, 2)")]
        public decimal SingleUsage { get; set; } = 1;
        //单价
        [Column(TypeName = "decimal(15, 2)")]
        public decimal UnitPrice { get; set; } = 0;
        [Column(TypeName = "decimal(15, 2)")]
        public decimal UnitPrice1 { get; set; } = 0;
        //单车用量*单价=单台车售价
        [Column(TypeName = "decimal(15, 2)")]
        public decimal SumPrice { get; set; } = 0;
        //开发、模检、工装单价：分摊收入/（单车用量*分摊台数）
        [Column(TypeName = "decimal(15, 2)")]
        public decimal OtherPrice { get; set; } = 0;
        //分摊台数,取自分摊表
        public int OtherNumber { get; set; } = 0;
        [Column(TypeName = "decimal(15, 2)")]
        public decimal SingleNumber { get; set; } = 0;
        //分摊收入
        [Column(TypeName = "decimal(15, 2)")]
        public decimal Income { get; set; } = 0;
        //一次性支付金额
        [Column(TypeName = "decimal(15, 2)")]
        public decimal OneIncome { get; set; } = 0;
        //产品成本
        [Column(TypeName = "decimal(15, 2)")]
        public decimal ProductPrice { get; set; } = 0;
        //单车用量*产品单价（税费成本）
        [Column(TypeName = "decimal(15, 2)")]
        public decimal sProductPrice { get; set; } = 0;
        //各件单件人工成本
        [Column(TypeName = "decimal(15, 2)")]
        public decimal PersonPrice { get; set; } = 0;
        //单车用量*（各件单件人工成本）
        [Column(TypeName = "decimal(15, 2)")]
        public decimal sPersonPrice { get; set; } = 0;
        //单件机台成本
        [Column(TypeName = "decimal(15, 2)")]
        public decimal MichinePrice { get; set; } = 0;
        //单车用量*单件机台成本
        [Column(TypeName = "decimal(15, 2)")]
        public decimal sMachine { get; set; } = 0;
        [Display(Name = "零件类型"), MaxLength(5)]
        public string PartType { get; set; } 

        [Display(Name = "各种类型"), MaxLength(5)]
        public string DeptType { get; set; }
        public int BomId { get; set; } = 0;

        public int PriceCollectionId { get; set; }

    }
}
