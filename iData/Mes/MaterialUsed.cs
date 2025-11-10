using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Mes
{
    [Table(nameof(MaterialUsed))]
    public class MaterialUsed:Base
    {
        public string QRCode { get; set; }
        public string ItemMaster { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
