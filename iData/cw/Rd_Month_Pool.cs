using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.cw
{
    public class Rd_Month_Pool
    {
        public int Years { get; set; }
        public int Months { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Prices { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Sales { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Salary { get; set; }
        public string Location { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
