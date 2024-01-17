using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(Catering))]
    public class Catering
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(4)]
        public string Name { get; set; }
        [MaxLength(5)]
        public string DishType { get; set; }
        [MaxLength(10)]
        public string Week1 { get; set; }
        [MaxLength(10)]
        public string Week2 { get; set; }
        [MaxLength(10)]
        public string Week3 { get; set; }
        [MaxLength(10)]
        public string Week4 { get; set; }
        [MaxLength(10)]
        public string Week5 { get; set; }
        [MaxLength(10)]
        public string Week6 { get; set; }
        [MaxLength(10)]
        public string Week0 { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
