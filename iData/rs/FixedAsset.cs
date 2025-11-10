using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iData.rs
{
    [Table(nameof(FixedAsset))]
    public class FixedAsset:Base
    {
        [Display(Name = "资产大类"), MaxLength(20)]
        //电脑
        public string BigType { get; set; }
        [Display(Name ="资产类型"),MaxLength(20)]
        //电脑
        public string Type { get; set; }
        [Display(Name = "资产状态"), MaxLength(20)]
        //闲置、在用、报废
        public string Status { get; set; }
        [Display(Name = "备注")]
        public string Reason { get; set; }
        [Display(Name ="资产编号")]
        //财务赋予的唯一值
        public string AssetNumber { get; set; }
        [Display(Name = "资产名称")]
        //笔记本电脑、台式机电脑
        public string Name { get; set; }
        [Display(Name = "唯一识别ID")]
        public string UUID { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public float Money { get; set; }
        public DateTime? CheckDate { get; set; }
        //public DateTime? BuyDate { get; set; }
        public int? InvailId { get; set; }
        public string RequestId { get; set; }
        public int IsPan { get; set; }
    }
}
