using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cw
{
    [Table(nameof(FreightSplit))]
    public class FreightSplit : Base
    {
        public DateTime dDate { get; set; }
        [MaxLength(20)]
        public string cCusCode{get;set;}
        [MaxLength(120)]
        public string cInvCode { get; set; }
        [MaxLength(3)]
        public string uDataBase { get; set; }
        [Display(Name ="标准运费")]
        public float Standard { get; set; }
        [Display(Name = "标准分摊")]
        public float StandardSplit { get; set; }
        public float Cost { get; set; }
    }
}
