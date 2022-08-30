using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.tech
{
    [Table(nameof(ModelDetail))]
    public class ModelDetail : Base
    {
        //巡查次数
        public int Version { get; set; }
        //模具id
        public int ModelId { get; set; }
        //备注
        public string Note { get; set; }
        //是否参照
        public bool IsRef { get; set; } = false;
        [Display(Name = "机台号")]
        public int MachineNum { get; set; } = 0;
        //如无参照无值，如有参照，给予参照值
        [Display(Name = "参照某次")]
        public int rModelDetailId { get; set; } = 0;
    }
}
