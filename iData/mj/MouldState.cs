using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.mj
{
    [Table(nameof(MouldState))]
    public class MouldState:Base
    {
        [MaxLength(20),Display(Name ="模具号")]
        public string MouldNo { get; set; }
        [MaxLength(20), Display(Name ="项目名称")]
        public string ProjectName { get; set; }
        [MaxLength(20), Display(Name ="模具名称")]
        public string MouldName { get; set; }
        [MaxLength(20), Display(Name ="担当")]
        public string UserName { get; set; }
        [MaxLength(20), Display(Name ="T0试模")]
        public DateTime? T0Mould { get; set; }
        [Display(Name ="材料回厂")]
        public DateTime? MaterialBack { get; set; }
        [Display(Name ="模架回厂")]
        public DateTime? MouldBack { get; set; }
        [MaxLength(20), Display(Name ="模具进度")]
        public string MouldProgress { get; set; }
        [Display(Name ="备注")]
        public string Note { get; set; }
    }
}
