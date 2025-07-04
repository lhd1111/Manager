using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Mes
{
    [Table(nameof(VendorScan))]
    public class VendorScan : Base
    {
        public string ScanStr { get; set; }
        public string cInvCode { get; set; }
        public string cInvName { get; set; }
        public string cInvCodeAll { get; set; }
        public string cInvNameAll { get; set; }

        [MaxLength(50)]
        public string Batch { get; set; }
        [MaxLength(50)]
        public string mBatch { get; set; }
        [Column(TypeName = "decimal(20, 6)")]
        public decimal Quantity { get; set; }
        public string Num { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string POPodetailsId { get; set; }
        //0:正常;1:已收
        public int Status { get; set; } = 0;
        public int Prt { get; set; } = 1;
    
    }
}
