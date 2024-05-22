using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.System
{
    [Table(nameof(Workflow))]
    //流程表单，采用队列思路
    public class Workflow:TwoEnum
    {   
        //处理人工号
        public string gh { get; set; }
        //考虑到并行情况，用string
        public string Back { get; set; }
        public string Front { get; set; }
    }
}
