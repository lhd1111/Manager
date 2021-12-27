using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(PostQuestion))]
    public class PostQuestion:Base
    {
        [Display(Name = "部门名称")]
        public string DeptmentStr { get; set; }
        [Display(Name ="oa岗位id")]
        public int PostId { get; set; }
        [Display(Name ="考核id")]
        public int ModelId { get; set; }
        [Display(Name = "是否删除")]
        public bool IsDel { get; set; }
    }
}
