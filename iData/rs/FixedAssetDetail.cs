using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.rs
{   
    [Table(nameof(FixedAssetDetail))]
    public class FixedAssetDetail:Base
    {
        [Display(Name ="名称")]
        public string Name { get; set; }
        [Display(Name = "大小描述")]
        public string Number { get; set; }
        public string Describe { get; set; }
        public int FixedAssetId { get; set; }
    }
}
