using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Mes
{
    [Table(nameof(ThreePoint))]
    public class ThreePoint:Base
    {
        [MaxLength(50)]
        public string Org { get; set; }
        [MaxLength(50)]
        public string ItemMaster { get; set; }
        [MaxLength(60)]
        public string InvCode { get; set; }
        public string InvName { get; set; }
        public string InvStd { get; set; }
        public string CustomerCode { get; set; }
        public string Customer { get; set; }
        [MaxLength(50)]
        public string CustormerId { get; set; }
        public string SplitStr { get; set; }
        public string SplitInt { get; set; }
        public int IsDel { get; set; }
    }
}
