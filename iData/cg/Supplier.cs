using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cg
{
    [Table(nameof(Supplier))]
    public class Supplier : Base
    {
        [MaxLength(60), Display(Name = "供应商简称")]
        public string Name { get; set; }
        [MaxLength(100), Display(Name = "供应商全名")]
        public string FullName { get; set; }
        [MaxLength(20),Display(Name ="供应商类型")]
        public string SupplierType { get; set; }
        [MaxLength(100), Display(Name = "供应商地址")]
        public string Address { get; set; }
        [MaxLength(11), Display(Name = "供应商电话")]
        public string SupplierPhone { get; set; }
        [MaxLength(20), Display(Name = "联系人")]
        public string Contact { get; set; }
        [MaxLength(50),Display(Name = "邮箱")]
        public string PostMail { get; set; }
        [Display(Name = "账期")]
        public int AccountPeriod { get; set; }
        [Display(Name = "对账日")]
        public int AccountDay { get; set; }
        [Display(Name = "结账期")]
        public string AccountMonth { get; set; }

        [Display(Name="失效日期")]
        public DateTime? ValidDate { get; set; }
        [Display(Name = "是否有效")]
        public bool IsValid { get; set; } = false;

        [Display(Name="U8库别")]
        public string U8DataBase { get; set; }
        [Display(Name="备注")]
        public string Note { get; set; }
        public virtual List<SinglePrice> SinglePrices { get; set; } = new List<SinglePrice>();
        public virtual List<SupplierCertificate> SupplierCertificates { get; set; } = new List<SupplierCertificate>();
    }
}
