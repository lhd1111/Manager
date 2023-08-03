using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Marketing
{
    [Table(nameof(OaApply))]
    public class OaApply:Base
    {

        public int requestId { get; set; }
        //项目内部编号
        [MaxLength(10)]
        public string nbbh { get; set; }
        [MaxLength(20)]
        public int gh { get; set; }
        public string Description { get; set; }
        //评估类型的备注
        public string pglxNote { get; set; }
        [MaxLength(5)]
        public string Status { get; set; } = "跟进中";
        public string Note { get; set; }
        public string Question { get; set; }
        [Display(Name = "零件数量"), Column(TypeName = "decimal(3,2)")]
        public decimal Number { get; set; }
        public bool IsClose { get; set; }
    }
}
