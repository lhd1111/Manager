using iData.rs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.System
{
    [Table("Menu")]
    public class Menu: TreeBase<Menu>
    {
        [MaxLength(50)]
        public string Path { get; set; }
        [MaxLength(100)]
        public string Roles { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        public int iOrder { get; set; }
    }
}
