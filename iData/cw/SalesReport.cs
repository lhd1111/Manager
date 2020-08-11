using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cw
{
    [Table(nameof(SalesReport))]
    public class SalesReport:Base
    {
        [MaxLength(60)]
        public string CustomerName { get; set; }
        [MaxLength(60)]
        public string U8Code { get; set; }
        public int iQuantity { get; set; }
        public float iSum { get; set; }
        public float iPrice { get; set; }
        public DateTime? Period { get; set; }
        [MaxLength(3),Display(Name ="账套号")]
        public string cDataBase { get; set; }
    }
}
