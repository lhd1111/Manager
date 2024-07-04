using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.KPI
{
    [Table(nameof(NyConst))]
    public class NyConst:Base
    {
        public string Name { get; set; }
        public string Fw { get; set; }
        public int iOrder { get; set; }
    }
}
