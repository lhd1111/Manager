using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cg
{
    [Table(nameof(PurchaseDetail))]
    public class PurchaseDetail:Base
    {
        [Column(TypeName ="decimal(10,2)")]
        public float PayMoney { get; set; }

        public DateTime PayDate { get; set; }
        public DateTime? ActualPayDate { get; set; }
        //支付条件
        public string Condition { get; set; }
        public string PayNote { get; set; }
        //未支付，已完成，已终止
        public string PayStatus { get; set; }
        //责任人
        [MaxLength(20)]
        public string PayGh { get; set; }
        public bool IsTicket { get; set; } = false;
        public int ContractId { get; set; }
    }
}
