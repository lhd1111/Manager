using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Marketing
{
    [Table(nameof(PriceModel))]
    public class PriceModel : Base
    {

        [MaxLength(50)]
        public string ModelName{get;set;}

        [Display(Name = "出率")]
        public int OutRate { get; set; }
        [Display(Name = "预算金额")]
        public int BudgetAmount { get; set; }
        [Display(Name = "料头损失"), Column(TypeName = "decimal(6, 2)")]
        public decimal ModelLost { get; set; }
        [Display(Name = "浇口式样"), MaxLength(10)]
        public string jksy { get; set; }
        [Display(Name = "滑块油缸"), MaxLength(10)]
        public string hkyg { get; set; }
        [Display(Name = "顶出方式"), MaxLength(10)]
        public string dcfs { get; set; }
        [Display(Name = "各种类型"), MaxLength(5)]
        public string DeptType { get; set; }
        public int BomId { get;set;}
        public int PriceCollectionId { get; set; }
    }
}
