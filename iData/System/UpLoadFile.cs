using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.System
{
    [Table(nameof(UpLoadFile))]
    public class UpLoadFile:Base
    {
        [MaxLength(60), Display(Name = "图片名称")]
        public string Name { get; set; }
        [Display(Name = "路径")]
        public string Path { get; set; }
        [Display(Name = "所属类")]
        public string Type { get; set; }
        [Display(Name = "后缀")]
        public string Suffix { get; set; }
        [Display(Name ="类id")]
        public int TypeId { get; set; }
        [Display(Name ="是否有效")]
        public bool IsValid { get; set; } = false;
    }
}
