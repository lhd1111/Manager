using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(SystemCheck))]
    public class SystemCheck : Base
    {
        [Display(Name = "文件名称"), MaxLength(50)]
        public string Name { get; set; }
        [Display(Name = "审核标准")]
        public string Standard { get; set; }
        [Display(Name = "关键点"), MaxLength(50)]
        public string KeyPoint { get; set; }
        [Display(Name = "标准删除")]
        public bool IsDel { get; set; }
        [Display(Name = "责任部门")]
        public string DepartmentStr { get; set; }
        public int iOrder  {get;set;}

    }
}
