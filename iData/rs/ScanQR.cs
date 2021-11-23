using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.rs
{
    [Table(nameof(ScanQR))]
    public class ScanQR:Base
    {
        [Display(Name ="表名")]
        public string TableName { get; set; }
    }
}
