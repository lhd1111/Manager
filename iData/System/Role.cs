using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.System
{
    [Table("Role")]
    public class Role:Base
    {
        [Required,Display(Name ="角色名"),MaxLength(20)]
        public string Name { get; set; }


        public virtual List<AccountRole> Accounts { get; set; } = new List<AccountRole>();
    }
}
