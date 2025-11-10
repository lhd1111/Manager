using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Mes
{
    [Table(nameof(Bao_gy))]
    public class Bao_gy : TreeBase<Bao_gy>
    {
        [MaxLength(50)]
        public string Org { get; set; }
        [MaxLength(50)]
        public string Code { get; set; }
        [MaxLength(50)]
        public string CodeName { get; set; }
        public string CodeId { get; set; }
        //总效期，单位：年
        public int zPeriod { get; set; }
        //开封效期，单位：分钟
        public int uPeriod { get; set; }
        //控制不同类型的页面，为1时装配页面（若有多个总成页面）另表处理
        public int eType { get; set; }
        public int iOrder { get; set; } = 1;
        public int IsDel { get; set; } = 0;

    }
}
