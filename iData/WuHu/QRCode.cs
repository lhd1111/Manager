using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.WuHu
{
    [Table(nameof(QRCode))]
    public class QRCode : Base 
    {
        public string cInvCode { get; set; }
        [MaxLength(3)]
        public string u8db { get; set; }
        public string Number { get; set; }
        [MaxLength(20)]
        public string gh { get; set; }
    }
}
