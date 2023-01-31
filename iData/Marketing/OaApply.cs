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
        [MaxLength(5)]
        public string Status { get; set; } = "跟进中";
        public string Note { get; set; }
        public bool IsClose { get; set; }
    }
}
