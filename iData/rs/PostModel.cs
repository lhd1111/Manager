using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.rs
{
    [Table(nameof(PostModel))]
    public class PostModel : Base
    {
        [Display(Name = "考核类型")]
        public string Type { get; set; }
        [Display(Name = "部门")]
        public string DepartmentStr { get; set; }
        [Display(Name = "标题")]
        public string Title { get; set; }
        [Display(Name = "描述")]
        public string Description { get; set; }
        [Display(Name ="是否删除")]
        public bool IsDel { get; set; }
    }
}
