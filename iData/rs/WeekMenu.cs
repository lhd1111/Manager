using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(WeekMenu))]
    public class WeekMenu : Base
    {
        public DateTime Day { get; set; }
        public int CateringId { get; set; }
        public int DishId { get; set; }
    }
}
