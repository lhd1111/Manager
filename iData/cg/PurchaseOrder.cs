using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Text;

namespace iData.cg
{
    [Table("PurchaseOrder")]
    public class PurchaseOrder:Base
    {
        [Display(Name = "入库单编号"), MaxLength(30)]
        public string cCode { get; set; }
        [Display(Name = "采购类型"), MaxLength(10)]
        //01.项目采购;02.批量采购;03.零星采购,04.办公采购;05.让步接收入库
        public string cPTCode { get; set; }
        [Display(Name="入库单号"),MaxLength(30)]
        public int RdRecordId { get; set; }
        [Display(Name = "入库单子表")]
        public int RdsId { get; set; }
        
        [Display(Name = "采购订单号"), MaxLength(30)]
        public string cOrderCode { get; set; }
        [Display(Name = "采购订单子表"), MaxLength(30)]
        public int iPOsID { get; set; }
        [Display(Name = "到货单号"), MaxLength(30)]
        public string cARVcode { get; set; }
        [Display(Name = "发票单号"), MaxLength(30)]
        public int? PBVId { get; set; }
        [Display(Name = "发票号"), MaxLength(30)]
        public string cPBVCode { get; set; }
        [Display(Name ="收票日期")]
        public DateTime ReceiveDate { get; set; }
        [MaxLength(60),Display(Name ="零件编号")]
        public string U8Code { get; set; }
        [Display(Name = "入库数量")]
        public float iQuantity { get; set; }
        [Display(Name = "开票数量")]
        public float fQuntity { get; set; }
        [Display(Name = "开票单价")]
        public float Price { get; set; } = 0;
        public int Tax { get; set; } = 13;
        public float TaxPrice { get; set; }
        [Display(Name ="税费")]
        public float iTaxPriceSum { get; set; }
        public float iSum { get; set; }
        public float iTaxSum { get; set; }
        [Display(Name ="结账期")]
        public string AccountMonth { get; set; }
        [Display(Name = "库别"),MaxLength(3)]
        public string DataBase { get; set; }
        [Display(Name = "入库日期")]
        public DateTime dDate { get; set; }
        [Display(Name = "开票日期")]
        public DateTime? iDate { get; set; }
        [Display(Name = "备注")]
        public string Note { get; set; }
        [ForeignKey("SupplierId")]
        [Display(Name = "供应商")]
        public int SupplierId { get; set; }
    }
}
