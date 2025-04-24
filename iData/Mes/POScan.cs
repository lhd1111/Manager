using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Mes
{
    [Table(nameof(POScan))]
    public class POScan:Base
    {
        public string ScanStr { get; set; }
        [MaxLength(50)]
        public string cInvCode { get; set; }
        public string Batch { get; set; }
        public string Quantity { get; set; }
        public string Num { get; set; }
        public string POPodetailsId { get; set; }
        public string PUArrivalVouchsId { get; set; }
        //0:正常;1:重复
        public int Status { get; set; } = 0;

    }
}
