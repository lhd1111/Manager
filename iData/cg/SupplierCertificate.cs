using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;

namespace iData.cg
{
    [Table("SupplierCertificate")]
    public class SupplierCertificate : Base
    {
        [MaxLength(60), Display(Name = "证书名称")]
        public string Name { get; set; }
        [Display(Name = "有效截止日期")]
        public DateTime ValidDate { get; set; }

        public bool IsValid { get; set; } = false;
        [Display(Name ="照片路径")]
        public string Path { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

    }
}