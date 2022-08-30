using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.tech
{
    [Table(nameof(CheckDetail))]
    public class CheckDetail:TreeBase<CheckDetail>
    {
        [MaxLength(10)]
        public string Value1 { get; set; }
        [MaxLength(10)]
        public string Value2 { get; set; }
        [MaxLength(10)]
        public string Value3 { get; set; }
        [MaxLength(10)]
        public string Value4 { get; set; }
        [MaxLength(10)]
        public string Value5 { get; set; }
        [MaxLength(10)]
        public string Value6 { get; set; }
        public string Path { get; set; }
        [MaxLength(10)]
        public string Value7 { get; set; }   
        //排序
        public int iOrder { get; set; }
        //检测次数0为模板
        public int ModelDetailId { get; set; }
    }
}
