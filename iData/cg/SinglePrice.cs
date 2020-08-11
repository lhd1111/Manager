using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cg
{
    [Table(nameof(SinglePrice))]
    public class SinglePrice : Base
    {
        [MaxLength(60),Display(Name="零件名称")]
        public string Name { get; set; }
        [MaxLength(100), Display(Name = "规格")]
        public string Specs { get; set; }
        [MaxLength(60)]
        public string U8Code { get; set; }
        [Display(Name = "价格起效开始时间")]
        public DateTime? StartDate { get; set; }
        [Display(Name = "价格起效结束时间")]
        public DateTime? EndDate { get; set; }
        [Display(Name = "确认日期")]
        public DateTime? ConfirmDate { get; set; }
        public string U8DataBase { get; set; }
        [Display(Name ="专用数据库")]
        public string SpecialDataBase { get; set; }
        public float Price { get; set; } = 0;
        public int Tax { get; set; }
        public float TaxPrice { get; set; }
        public bool IsValid { get; set; } = false;
        [ForeignKey("SupplierId")]
        public Supplier Supplier {get;set;}


    }
}
