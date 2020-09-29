using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cw
{
    [Table(nameof(ProductSale))]
    public class ProductSale:Base
    {
        [Display(Name = "供应商编码"), MaxLength(20)]
        public string cCusCode { get; set; }
        [Display(Name = "供应商名称"), MaxLength(98)]
        public string cCusName { get; set; }
        [Display(Name = "存货编码"), MaxLength(120)]
        public string cInvCode { get; set; }
        [Display(Name = "存货名称"), MaxLength(510)]
        public string cInvName { get; set; }
        [Display(Name = "规格型号"), MaxLength(50)]
        public string cInvStd { get; set; }
        [Display(Name = "客户零件号"), MaxLength(50)]
        public string cCusInvCode { get; set; }
        [Display(Name = "预算价"), MaxLength(50)]
        public float fButgetPrice { get; set; }
        [Display(Name = "临时价"), MaxLength(50)]
        public float fTempPrice { get; set; }
        [Display(Name = "定价"), MaxLength(50)]
        public float fDefinePrice { get; set; }
        [Display(Name =("是否协议价"))]
        public bool IsAgreement { get; set; }
        [Display(Name = ("是否内部定价"))]
        public bool IsInward { get; set; }
        [Display(Name = ("备注")),MaxLength(200)]
        public string Note { get; set; }
        [Display(Name = "库别"), MaxLength(3)]
        public string uDataBase { get; set; }
        [Display(Name = ("模具分摊"))]
        public int? ModelSplitCostId { get; set; }
    }
}
