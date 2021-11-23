using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.System
{
    [Table(nameof(ContractUpLoadFile))]
    public class ContractUpLoadFile : UpLoadFile
    {
        [Display(Name="开始日期")]
        public DateTime StartDate { get; set; }
        [Display(Name = "结束日期")]
        public DateTime EndDate { get; set; }
    }
}
