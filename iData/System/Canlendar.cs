using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.System
{
    [Table(nameof(Canlendar))]
    public class Canlendar
    {
        [Key]
        public DateTime iDate  { get; set; }
    }
}
