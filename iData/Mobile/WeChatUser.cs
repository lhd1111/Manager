using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.Mobile
{
    [Table(nameof(WeChatUser))]
    public class WeChatUser
    {   
        [Key]
        [Display(Name ="微信openid"),MaxLength(32)]
        public string OpenId { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
