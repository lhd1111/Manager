using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cw
{
    [Table(nameof(SalesFreight))]
    public class SalesFreight:Base
    {
        [Display(Name = "供应商编码"), MaxLength(20)]
        public string cCusCode { get; set; }
        [Display(Name = "供应商名称"), MaxLength(98)]
        public string cCusName { get; set; }
        [Display(Name = "存货编码"), MaxLength(120)]
        public string cInvCode { get; set; }
        [Display(Name = "存货名称"), MaxLength(510)]
        public string cInvName { get; set; }
        [Display(Name = "规格型号"), MaxLength(50)]
        public string cInvStd { get; set; }
        [Display(Name = "单个包装")]
        public float fPacking { get; set; }
        [Display(Name = "单个运费")]
        public float fFreight { get; set; }
        [Display(Name = "三方运费")]
        public float fOtherFreight { get; set; }
        [Display(Name = "库别"), MaxLength(3)]
        public string uDataBase { get; set; }
    }
}
