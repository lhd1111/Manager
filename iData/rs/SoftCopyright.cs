using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using iData.System;

namespace iData.rs
{
    [Table(nameof(SoftCopyright))]
    public class SoftCopyright:Base
    {
        [Display(Name="软著号")]
        public string NameNumber { get; set; }
        [Display(Name = "名称")]
        public string Name { get; set; }
        [Display(Name = "类别")]
        public string SoftType { get; set; }
        [Display(Name = "专利申请日")]
        public DateTime AskDate { get; set; }
        [Display(Name = "授权起效日")]
        public DateTime? StartDate { get; set; }
        [Display(Name = "授权失效日")]
        public DateTime? EndDate { get; set; }
        [Display(Name = "获得方式")]
        public string SoftMethod { get; set; }
        [Display(Name = "证书"),MaxLength(2)]
        public string Certificate { get; set; }
        [Display(Name = "是否代理"),MaxLength(2)]
        public string Getway { get; set; }
        [Display(Name = "网络核查"), MaxLength(2)]
        public string InternetCheck { get; set; }
    }
}
