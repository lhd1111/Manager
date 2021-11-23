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
        [Display(Name = "宿舍Id"), MaxLength(20)]
        public string SuSheId { get; set; }
        [Display(Name = "班制"), MaxLength(10)]
        public string BanZhi { get; set; }
        [Display(Name = "开始日期")]
        public DateTime StartDate { get; set; }
        [Display(Name = "搬出日期")]
        public DateTime? EndDate { get; set; }
        [Display(Name = "住宿费"), Column(TypeName = "decimal(8, 2)")]
        public decimal ZhuSu { get; set; }
        [Display(Name = "水费"), Column(TypeName = "decimal(8, 2)")]
        public decimal ShuiFei { get; set; }
        [Display(Name = "电费"), Column(TypeName = "decimal(8, 2)")]
        public decimal DianFei { get; set; }
        [Display(Name = "气费"), Column(TypeName = "decimal(8, 2)")]
        public decimal QiFei { get; set; }
        [Display(Name = "清洁费"), Column(TypeName = "decimal(8, 2)")]
        public decimal QingJieFei { get; set; }
        [Display(Name = "其他费"), Column(TypeName = "decimal(8, 2)")]
        public decimal QiTaFei { get; set; }
        [Display(Name = "总费用"), Column(TypeName = "decimal(8, 2)")]
        public decimal zj { get; set; }
    }
}
