using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(LeaveCost))]
    public class LeaveCost:Base
    {
        //public int CompanyId { get; set; }
        public string CompanyStr { get; set; }
        [Display(Name ="岗位星级")]
        public string GwxjStr { get; set; }
        [Display(Name ="离职成本")]
        //含倍数
        public float LzCost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
