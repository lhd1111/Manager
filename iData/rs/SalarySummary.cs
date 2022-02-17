using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.rs
{
    [Table(nameof(SalarySummary))]
    public class SalarySummary:Base
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        
        public DateTime Period { get; set; }
        [Display(Name = "薪资类型"), MaxLength(3)]
        public string SalaryType { get; set; }
        [Display(Name = "薪资类型名"), MaxLength(10)]
        public string SalaryName { get; set; }
        public int AttendanceCount { get; set; }
        public int AttendanceError { get; set; }
        public int SalaryCount { get; set;}
        public int SalaryError { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal SalarySum { get; set; }

    }
}
