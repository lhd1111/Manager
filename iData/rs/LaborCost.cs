using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(LaborCost))]
    public class LaborCost:Base
    {
        [Display(Name ="年"),MaxLength(4)]
        public string iYear { get; set; }
        [Display(Name ="月"),MaxLength(2)]
        public string iMonth { get; set; }
        [Display(Name ="日期")]
        public DateTime dDate { get; set; }
        [Display(Name = "汇总方式"),MaxLength(10)]
        public string SummaryType { get; set; }
        [Display(Name ="汇总部门"),MaxLength(10)]
        public string mDepartmnet { get; set; }
        [Display(Name = "汇总类别"), MaxLength(10)]
        //如：一线、一线辅助、直接管理等
        public string mType { get; set; }
        [Display(Name ="预算")]
        public float? Budget { get; set; }
        [Display(Name ="全年预算占比")]
        public float? BudgetRate { get; set; }
        [Display(Name ="应发")]
        public float yf { get; set; }
        [Display(Name = "应发其它")]
        public float yfqt { get; set; }
        [Display(Name = "应发人数")]
        public float yfrs { get; set; }
        [Display(Name = "销售额")]
        public float? SaleMoney { get; set; }
    }
}
