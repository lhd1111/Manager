using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace iData.cg
{
    [Table(nameof(PurchaseContract))]
    public class PurchaseContract:Base
    {
        public string ContractNumber { get; set; }
        public string ContractName { get; set; }
        public int ContractA { get; set; }
        //乙方，来源Supplier
        public int ContractB { get; set; }
        public string ContractType { get; set; }
        public DateTime ContractDate { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public float ContractMoney { get; set; }
        public string Note { get; set; }
        [MaxLength(20)]
        public string ContractGh { get; set; }
        public bool IsClose { get; set; } = false;
    }
}
