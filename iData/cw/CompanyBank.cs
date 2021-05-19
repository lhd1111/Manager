using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cw
{
    [Table(nameof(CompanyBank))]
    public class CompanyBank:Base
    {
        [Display(Name = "单位Id"), MaxLength(98)]
        public int dwId { get; set; }
        [Display(Name = "单位名称"), MaxLength(98)]
        public string dwStr { get; set; }
        [Display(Name = "银行名称"), MaxLength(98)]
        public string BankName { get; set; }

    }
}
