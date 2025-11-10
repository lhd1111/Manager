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
        //自己的码
        public string mScanStr { get; set; }
        //对方的码
        public string ScanStr { get; set; }
        //行id
        public string SoId { get; set; }
        //销售订单id
        public string Mo_SoId { get; set; }
        [MaxLength(60)]
        public string InvCode { get; set; }
        [MaxLength(60)]
        public string Batch { get;set; }
        public string Num { get; set; }
        public int Quantity { get; set; }
        // 0:未验证, 1:通过, 2:异常
        public int IsPass { get; set; } = 0; 
    }
}
