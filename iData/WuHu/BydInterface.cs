using iData.rs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.WuHu
{
    [Table(nameof(BydInterface))]
    public class BydInterface:Base
    {
        [MaxLength(100)]
        public string cInvCode { get; set; }
        [MaxLength(100)]
        public string cInvName { get; set; }
        [MaxLength(100)]
        public string cCustomerCode { get; set; }
        [MaxLength(100)]
        public string timestamp { get; set; }
        public int iQuantity { get; set; }

        public string ResByd { get; set; }
    }
}
