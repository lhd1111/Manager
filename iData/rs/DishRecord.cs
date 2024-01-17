using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(DishRecord))]
    public class DishRecord : Base
    {
        [MaxLength(5)]
        public string kw { get; set; }
        [MaxLength(2)]
        public string fl { get; set; }
        public float je { get; set; }
        public DateTime DishTime { get; set; }
        public string Note { get; set; }
        [MaxLength(2)]
        public string IsQc { get; set; }
        [MaxLength(20)]
        public string gh { get; set; }
        public int DishNameId{get;set;}
    }
}
