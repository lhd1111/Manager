using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cw
{
    [Table(nameof(Invoice))]
    public class Invoice:Base
    {
        public string InvoiceNumber{get; set;}
        //普通发票、增值税票、火车票
        public string InvoiceType { get; set; }
        //发票日期
        public string InvoiceDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNumber { get; set; }
        
        [Column(TypeName = "decimal(8, 2)")]
        public decimal hj { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal se { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal zj { get; set; }
        public string description { get; set; }
        public string requestId { get; set; }
        public string docId { get; set; }
        //是否在OA内创建了子记录
        public bool IsCreate { get; set; }
    }
}
