using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(PostResult))]
    public class PostResult:Base
    {
        [Display(Name = "关联类型")]
        public string Type { get; set; }
        [Display(Name = "关联表")]
        public string TableName { get; set; }
        [Display(Name = "表项")]
        public int TableId { get; set; }
        [Display(Name = "工号")]
        public int gh { get; set; }
        [Display(Name = "得分")]
        public int Score { get; set; }
        [Display(Name = "他评")]
        public int Score1 { get; set; }
    }
}
