using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Mes
{
    [Table(nameof(ThreePointDetail))]
    public class ThreePointDetail:Base
    {
        public int ThreePointId { get; set; }

        public string ScanStr { get; set; }
        [MaxLength(60)]
        public string InvCode { get; set; }
        public int GroupId { get; set; }
        //来源,0:fs,1:客户
        public int Source { get; set; } = 0;
        // 0:未验证, 1:通过, 2:异常
        public int IsPass { get; set; } = 0; 
    }
}
