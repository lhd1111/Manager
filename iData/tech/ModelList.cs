using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.tech
{
    [Table(nameof(ModelList))]
    public class ModelList:Base
    {
        [Display(Name = "模具编号"), MaxLength(20)]
        public string ModelNum { get; set; }

        [Display(Name ="模具名称"),MaxLength(50)]
        public string ModelName { get; set; }
        [Display(Name = "模具类型"), MaxLength(50)]
        public string ModelType { get; set; }
        //[Display(Name = "零件号"), MaxLength(50)]
        //public string ModelName { get; set; }

        [MaxLength(50), Display(Name = "项目编号")]
        public string Code { get; set; }

    }
}
