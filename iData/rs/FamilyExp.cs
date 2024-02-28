using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(FamilyExp))]
    public class FamilyExp:Base
    {
        [MaxLength(10), Display(Name = "姓名")]
        public string Name { get; set; }
        public int Age { get; set; }
        [MaxLength(10),Display(Name ="称呼")]
        public string Title { get; set; }
        [MaxLength(10), Display(Name = "工作单位")]
        public string CompanyStr { get; set; }
        [MaxLength(11), Display(Name = "联系电话")]
        public string Tel { get; set; }


    }
}
