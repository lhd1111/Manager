using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Mes
{
    [Table(nameof(BaoHouse))]
    public class BaoHouse:Base
    {
        public string Org { get; set; }
        public string hName { get; set; }
        public string hQRCode { get; set; }
        public int IsDel { get; set; } = 0;
        //原料容器,产成品容器
        public string Type { get; set; }
    }
}
