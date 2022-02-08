using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(PersonTest))]
    public class PersonTest:Base
    {
        public string gh { get; set; }
        [Display(Name ="试卷信息")]
        public int PaperId { get; set; }
        [Display(Name ="得分"), Column(TypeName = "decimal(8, 2)")]
        public decimal Socre { get; set; }
        [Display(Name = "卷面总分")]
        public int PaperSocre { get; set; }
        [Display(Name = "百分换算"), Column(TypeName = "decimal(8, 2)")]
        public decimal SocreRate { get; set; } 
        [Display(Name = "耗时")]
        public int Duration { get; set; }

    }
}
