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
        [MaxLength(60)]
        public string InvCode { get; set; }
        public string InvName { get; set; }
        public string InvStd { get; set; }
        public string CustomerCode { get; set; }
        public string Customer { get; set; }
        public string SplitStr { get; set; }
        public int SplitInt { get; set; }
    }
}
