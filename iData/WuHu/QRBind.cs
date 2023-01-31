using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.WuHu
{
    [Table(nameof(QRBind))]
    public class QRBind:Base
    {
        public string Name {get; set; }
        public string Bind { get; set; }
        [MaxLength(20)]
        public string gh { get; set; }
    }
}
