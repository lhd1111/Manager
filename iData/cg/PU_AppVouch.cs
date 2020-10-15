using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cg
{
    [Table(nameof(PU_AppVouch))]
    public class PU_AppVouch:Base
    {
        [Display(Name = "请购单号")]
        public int PU_AppVouchId { get; set; }
        [Display(Name = "请购单明细")]
        public int PU_AppVouchsId { get; set; }
        [Display(Name = "Oa类型")]
        public string OaType { get; set; }
        [Display(Name = "Oa表")]
        public string OaTable { get; set; }
        [Display(Name = "OaId")]
        public int OaId { get; set; }
        [Display(Name = "库别"), MaxLength(3)]
        public string cDataBase { get; set; }
    }
}
