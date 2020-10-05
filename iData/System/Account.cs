using iData.rs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.System
{
    [Table("Account")]
    public class Account:Base
    {
        [Required,Display(Name ="登录名"),MaxLength(20)]
        public string LoginName { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(50),Display(Name ="Email")]
        public string Email { get; set; }
        [Display(Name="姓名"),MaxLength(20)]
        public string Name { get; set; }
        [Display(Name="财务U8账户名"),MaxLength(20)]
        public string CwName { get; set; }
        [Display(Name = "人事U8账户名"),MaxLength(20)]
        public string RsName { get; set; }
        [Display(Name = "Oa账户名"),MaxLength(20)]
        public string OaName { get; set; }
        [Display(Name ="用户id")]
        public int PersonId { get; set; }
        [Display(Name = "微信openid"), MaxLength(32)]
        public string wxOpenId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        public DateTime? LastLoginTime { get; set; }


        public virtual List<AccountRole> Roles { get; set; } = new List<AccountRole>();
    }
}
