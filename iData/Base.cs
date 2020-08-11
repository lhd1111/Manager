using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iData
{
    public abstract class Base
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        [MaxLength(20)]
        public string CreateUser { get; set; }
        public DateTime? ModifyTime { get; set; }
        [MaxLength(20)]
        public string ModifyUser { get; set; }
    }
}
