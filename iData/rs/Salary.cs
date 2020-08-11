using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Text;

namespace iData.rs
{
    public class Salary:Base
    {
        public Person Person { get; set; }
        public float Money { get; set; }
        public DateTime StartDate { get; set; }
        public int DueMonth { get; set; } = 0;
        public DateTime EndDate { get; set; }
        [MaxLength(50)]
        public string Note { get; set; }
    }
}
