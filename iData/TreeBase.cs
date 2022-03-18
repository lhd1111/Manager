using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iData
{
    public abstract class TreeBase<T> where T:class
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        [MaxLength(20)]
        public string CreateUser { get; set; }
        public DateTime? ModifyTime { get; set; }
        [MaxLength(20)]
        public string ModifyUser { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(int.MaxValue)]
        public string Scope { get; set; }
        public int Level { get; set; }
        public bool IsLeaf { get; set; }
        public int? ParentId { get; set; }
        public virtual T Parent { get; set; }
        public virtual ICollection<T> Children { get; set; }

    }
}
