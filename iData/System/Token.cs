using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.System
{   
    [Table(nameof(Token))]
    public class Token
    {
        [Display(Name = "终端类型")]
        public string SoftType { get; set; }
        [Display(Name = "证书类型")] 
        public string TokenType { get; set; }
        [Display(Name ="票据")]
        public string Ticket { get; set; }
        public DateTime Invaild { get; set; }
    }
}
