using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(CanteeMenu))]
    public class CanteeMenu:Base
    {
        //菜品类别
        public string DishType { get; set; }

        [MaxLength(20)]
        public string DishName { get; set; }
        [MaxLength(1)]
        public string IsCg { get; set; }
        public int SmallPrice { get; set; }
        public int BigPrice { get; set; }
        public string DishNote { get; set; }
        public int ForceMinute { get; set; }
    }
}
