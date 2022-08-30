using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.tech
{
    [Table(nameof(StandardHistory))]
    public class StandardHistory:Base
    {
        //哪个标准
        public int ModelDetailId { get; set; }
        //开始时间，除非更替
        public DateTime StartDate { get; set; } = DateTime.Now;


    }
}
