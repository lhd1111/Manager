using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Mes
{
    [Table(nameof(Bao_GyUsed))]
    public class Bao_GyUsed:Base
    {
        public DateTime? StartTime { get; set; }
        public DateTime? LastTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Org { get; set; }
        public string mMo { get; set; }
        public string GyId { get;set; }
        public string QRCode { get; set; }
        public string pQRCode { get; set; }
        public string Box { get; set; }
        //前道工艺容器
        public string front { get; set; }
        public int iOrder { get; set; }
        //架子为数量，物料为质保期
        public int Number { get; set; }
        public int Interval { get; set; }
        public string cInvCode { get; set; }
        //原料id
        public string mItemMaster { get; set; }
        //父级件id
        public string pItemMaster { get; set; }
        //2:工艺;3.原料
        public int uLevel { get; set; }
        //0:初始；1：在制;2:已放满;3:已使用
        public int Status { get; set; }
    }
}
