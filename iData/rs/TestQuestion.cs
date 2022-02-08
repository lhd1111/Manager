using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.rs
{
    [Table(nameof(TestQuestion))]
    public class TestQuestion:Base
    {
        [Display(Name = "试卷id")]
        public int TestId { get; set; }
        [Display(Name = "考核id")]
        public int ModelId { get; set; }
        [Display(Name = "是否删除")]
        public bool IsDel { get; set; }=false;
    }
}
