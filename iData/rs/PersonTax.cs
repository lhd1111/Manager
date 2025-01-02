using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(PersonTax))]
    public class PersonTax:Base
    {
        [Display(Name = "D(4)身份证"), MaxLength(18)]
        public string CardNumber { get; set; }
        [Display(Name = "H(8)本期收入"), Column(TypeName = "decimal(8, 2)")]
        public decimal Sr { get; set; }
        [Display(Name = "I(9)本期费用"), Column(TypeName = "decimal(8, 2)")]
        public decimal Fy { get; set; }
        [Display(Name = "J(10)本期免税收入"), Column(TypeName = "decimal(8, 2)")]
        public decimal Mrsr { get; set; }
        [Display(Name = "AK(37)累计应补(退)税额"), Column(TypeName = "decimal(8, 2)")]
        public decimal sYbts { get; set; }
        [Display(Name = "AL(38)备注")]
        public string Note { get; set; }
        [MaxLength(3)]
        public string DataBaseId { get; set; }
        public DateTime Period { get; set; }
    }
}
