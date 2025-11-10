using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Mes
{
    [Table(nameof(VendorScans))]
    public class VendorScans:Base
    {
        public string ScanStr { get; set; }
        public int Quantity { get; set; }
        public string Num { get; set; }
        public int VendorScanId { get; set; }
        public string Source { get;set; }
    }
}
