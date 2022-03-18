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
        [Display(Name ="资产类型"),MaxLength(20)]
        public string Type { get; set; }
        [Display(Name = "资产状态"), MaxLength(20)]
        public string Status { get; set; }
        [Display(Name = "备注")]
        public string Reason { get; set; }
        [Display(Name ="资产编号")]
        public string AssetNumber { get; set; }
        [Display(Name = "资产名称")]
        public string Name { get; set; }
        public DateTime BuyDate { get; set; }
        [Display(Name = "部门id")]
        public int DepartmentId { get; set; }
        [Display(Name ="姓名"),MaxLength(20)]
        public string PersonName { get; set; }
        [Display(Name ="工号"),MaxLength(20)]
        public string gh { get; set; }
    }
}
