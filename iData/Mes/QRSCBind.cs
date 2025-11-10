using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Mes
{
    [Table(nameof(QRSCBind))]
    public class QRSCBind:Base
    {
        public string zQRCode { get; set; }
        public string fQRCode { get; set; }
        public string Org{ get; set; }
        public int IsDel { get; set; } = 0;
    }
}
