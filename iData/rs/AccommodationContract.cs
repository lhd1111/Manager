using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(AccommodationContract))]
    public class AccommodationContract:Base
    {
        [Display(Name= "租赁方名称")]
        public string CoustmerName { get; set; }
        [Display(Name = "宿舍名称"), MaxLength(50)]
        public string SusheName { get; set; }
        [Display(Name = "宿舍地址"), MaxLength(100)]
        public string SusheAddr { get; set; }
        [Display(Name = "最大人数")]
        public int MaxPeople { get; set; }
        [Display(Name = "员工付费")]
        public string PayMethod { get; set; }
        [Display(Name ="合同开始日期")]
        public DateTime StartDate { get; set; }
        [Display(Name = "合同结束日期")]
        public DateTime EndDate { get; set; }
        [Display(Name = "租赁类型"),MaxLength(4)]
        public string Type { get; set; }
        [Display(Name = "付款方式"), MaxLength(20)]
        public string Method { get; set; }
        [Display(Name = "租金")]
        public string Money { get; set; }
        [Display(Name ="签订日期")]
        public DateTime? SignDate { get; set; }
        [Display(Name = "数据库编号")]
        public string DataBaseId { get; set; }
        [Display(Name = "部门id")]
        public string DepartmentId { get; set; }
    }
}
