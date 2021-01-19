using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cw
{
    [Table(nameof(ModelSplitCost))]
    public class ModelSplitCost:Base
    {
        [Display(Name = "供应商编码"), MaxLength(20)]
        public string cCusCode { get; set; }
        [Display(Name = "供应商名称"), MaxLength(98)]
        public string cCusName { get; set; }
        [Display(Name = "存货编码"),MaxLength(120)]
        public string cInvCode { get; set; }
        [Display(Name = "存货名称"),MaxLength(510)]
        public string cInvName { get; set; }
        [Display(Name = "规格型号"),MaxLength(50)]
        public string cInvStd { get; set; }
        [Display(Name = "项目"), MaxLength(50)]
        public string sProject { get; set; }
        [Display(Name ="分摊分组")]
        public int sGroup { get; set; }
        [Display(Name ="模具金额")]
        public float fModelCost { get; set; }
        [Display(Name = "分摊量纲")]
        public int iModelNum { get; set; }
        [Display(Name = "决算金额")]
        public float fFinalCost { get; set; } = 0;
        [Display(Name = "决算量纲")]
        public int iFinalNum { get; set; } = 0;
        [Display(Name = "模具单价")]
        public float fPrice { get; set; }
        [Display(Name = "已开数量")]
        public int iModelNumed { get; set; } = 0;
        [Display(Name = "备注"),MaxLength(200)]
        public string Note { get; set; }
        [Display(Name = "是否侦测")]
        public bool IsTest { get; set; } = true;
        [Display(Name ="库别"),MaxLength(3)]
        public string uDataBase { get; set; }
    }
}
