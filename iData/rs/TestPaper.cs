using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.rs
{
    [Table(nameof(TestPaper))]
    public class TestPaper:Base
    {
        [Display(Name = "试卷/岗位类型")]
        public string Type { get; set; }
        [Display(Name ="试卷/岗位名称")]
        public string Name { get; set; }
        [Display(Name ="考试限时")]
        public int duration { get; set; }
        [Display(Name = "试卷总分")]
        public int PaperSocre { get; set; } = 0;
        [Display(Name ="是否删除")]
        public bool IsDel { get; set; }=false;
    }
}
