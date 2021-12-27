using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace iData.rs
{
    [Table(nameof(TestModel))]
    public class TestModel:Base
    {
        //[Display(Name = "考核种类")]
        //培训试题、岗位胜任力、培训评价
        //public string Type { get; set; }
        [Display(Name = "考核类型")]
        //单选、多选、评分、判断、简答
        public string Type { get; set; }
        [Display(Name = "适用部门")]
        public string DepartmentStr { get; set; }
        [Display(Name = "分类标签")]
        //通用类、专业类、理论知识。。。
        public string Tag { get; set; }
        [Display(Name = "标题")]
        public string Title { get; set; }
        [Display(Name = "描述")]
        public string Description { get; set; }
        [Display(Name ="分值")]
        public int Socre { get; set; }
        [Display(Name ="排序")]
        public int iOrder { get; set; }
        [Display(Name = "是否删除")]
        public bool IsDel { get; set; }

    }
}
