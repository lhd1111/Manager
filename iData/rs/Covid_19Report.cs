using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(Covid_19Report))]
    public class Covid_19Report:Base
    {
        //命名
        public string Name { get; set; }
        //开始日期
        public DateTime StartDate { get; set; }
        //结束日期
        public DateTime EndDate { get; set; }
    }
}
