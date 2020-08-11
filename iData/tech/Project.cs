using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.tech
{
    [Table("Project")]
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Display(Name = "项目编号")]
        public string Code { get; set; }
        [MaxLength(50), Display(Name = "顾客名称")]
        public string CustomName { get; set; }
        [MaxLength(50), Display(Name = "产品型号")]
        public string ProductCode { get; set; }
        [MaxLength(50), Display(Name = "产品名称")]
        public string ProductName { get; set; }
        [Display(Name ="产品阶段")]
        public StageType Stage { get; set; }

        public ICollection<bom> Boms { get; set; } = new List<bom>();
    }
    public enum StageType{
        [Display(Name ="DV")]
        DV=0,
        [Display(Name ="样件")]
        Sample=1,
        [Display(Name ="试生产")]
        Trial=2,
        [Display(Name ="批量")]
        Batch=3
    }
}
