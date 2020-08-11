using iData.System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(EducationExp))]
    public class EducationExp:Base
    {
        [Display(Name ="教育人")]
        public Person Person { get; set; }
        [Display(Name ="开始时间")]
        public DateTime StartDate { get; set; }
        [Display(Name ="结束时间")]
        public DateTime EndDate { get; set; }
        [Display(Name ="毕业学校"), MaxLength(50)]
        public string School { get; set; }
        [Display(Name = "学历")]
        public string Education { get; set; }
        [Display(Name = "专业"), MaxLength(20)]
        public string Profession { get; set; }
        [Display(Name = "是否全日制")]
        public bool IsFull { get; set; }
    }
}
