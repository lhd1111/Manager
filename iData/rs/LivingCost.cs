using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(LivingCost))]
    public class LivingCost:Base
    {
        [MaxLength(10)]
        public string gh { get; set; }
        public DateTime Period { get; set; }
        [MaxLength(3)]
        public string DataBaseId { get; set; }
        [Display(Name = "宿舍名"),MaxLength(20)]
        public string SuSheName { get; set; }
        [Display(Name = "班制"), MaxLength(10)]
        public string BanZhi { get; set; }
        [Display(Name = "开始日期")]
        public DateTime StartDate { get; set; }
        [Display(Name = "搬出日期")]
        public DateTime? EndDate { get; set; }
        [Display(Name = "住宿费")]
        public float ZhuSu { get; set; }
        [Display(Name = "水费")]
        public float ShuiFei { get; set; }
        [Display(Name = "电费")]
        public float DianFei { get; set; }
        [Display(Name = "气费")]
        public float QiFei { get; set; }
        [Display(Name = "清洁费")]
        public float QingJieFei { get; set; }
        [Display(Name = "其他费")]
        public float QiTaFei { get; set; }
        [Display(Name = "总费用")]
        public float zj { get; set; }
    }
}
