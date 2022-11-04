using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Quality
{
    [Table(nameof(Experience))]
    public class Experience:Base
    {
        public string LLR { get; set; }
        //项目编号
        public string Code { get; set; }
        public string ProjectName { get; set; }
        [Display(Name = "车型"), MaxLength(50)]
        public string CarType { get; set; }
        [Display(Name = "客户名称"), MaxLength(50)]
        public string CustomerName { get; set; }
        //问题起源
        public string ProblemSource { get; set; }
        //产品类别
        public string ProductType { get; set; }
        //问题分类
        public string ProblemClass { get; set; }
        //关键点
        public string KeyPoint { get; set; }
        [Display(Name = "描述")]
        public string Description { get; set; }
        [Display(Name = "工号"), MaxLength(20)]
        public string gh { get; set; }
        public string DepartmentStr { get; set; }
        //发生地点
        public string OccurrencePlace { get; set; }
        public DateTime OccurrenceDate { get; set; }
    }
}
