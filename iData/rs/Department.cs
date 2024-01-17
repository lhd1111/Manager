using iData.System;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public int? ParentId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string FullName { get; set; }
        [MaxLength(50)]
        public string Scope { get; set; }
        public int Level { get; set; }
        public int iOrder { get; set; }
        public bool IsLeaf { get; set; } = true;
        public int oDepartmentId { get; set; }
        [Display(Name="邮箱id")]
        public string mDepartmentId { get; set; }
        [Display(Name ="u8数据库编号")]
        public string uDataBase { get; set; }
        [Display(Name ="人事数据库编号")]
        public string rDataBase { get; set; }
        [Display(Name = "考勤数据库名称")]
        public string kDataBase { get; set; }
        [Display(Name ="工号前缀")]
        public string oGh { get; set; }
        public bool IsDel { get; set; } = false;
        public DateTime? DelTime { get; set; }
        public virtual Department Parent { get; set; }
        public virtual ICollection<Department> Children { get; set; }
        public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
        public virtual ICollection<Menu> Menus {get;set;}=new List<Menu>();

    }
}
