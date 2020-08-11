using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Display(Name ="工作经历"),Table(nameof(WorkExp))]
    public class WorkExp:Base
    {
        [Display(Name = "工作人")]
        public Person Person { get; set; }
        [Display(Name = "开始时间")]
        public DateTime StartDate { get; set; }
        [Display(Name = "结束时间")]
        public DateTime EndDate { get; set; }
        [MaxLength(50)]
        public string Company { get; set; }
        [MaxLength(20)]
        public string DepartmentStr { get; set; }
        [Display(Name = "工作岗位"), MaxLength(20)]
        public string PostStr { get; set; }
        [Display(Name ="离职原因")]
        public string Reason { get; set; }
        [Display(Name ="证明人电话")]
        public string CertifierTel { get; set; }
        [Display(Name = "证明人")]
        public string Certifier { get; set; }
    }
}
