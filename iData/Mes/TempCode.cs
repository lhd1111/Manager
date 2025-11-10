using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Mes
{
    [Table(nameof(TempCode))]
    public  class TempCode:Base
    {
        //单件码
        public string ScanStr { get; set; }
        //零件号
        public string cInvCode { get; set; }
        //零件名称
        public string cInvName { get; set; }
        //拼接全零件
        public string cInvCodeAll { get; set; }
        //拼接零件全名
        public string cInvNameAll { get; set; }
        //批次号
        [MaxLength(8)]
        public string Batch { get; set; }
        //数量
        public int Quantity { get; set; }
        //流水号
        public string Num { get; set; }
        public string Org { get; set; }
        public string ItemMaster { get; set; }
        public string Mo { get; set; }
        //工单编号
        public string DocNo { get; set; }
        //0:正常;1:已扫;2.已发(若有)3.报废
        public int Status { get; set; } = 0;
        //打印次数，正常才打
        public int Prt { get; set; } = 1;
        //1.单件码；2.箱码；3.托盘码
        public int type { get; set; } = 1;

    }
}
