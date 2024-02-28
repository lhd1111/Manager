using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace iData.System
{
    [Table(nameof(Signature))]
    public class Signature:Base
    {
        public int PersonId { get; set; }
        public string SignatureType { get; set; }
        [Display(Name = "工号"), MaxLength(10)]
        public string gh { get; set; }
        [Display(Name = "签名图像")]
        public string UserCanvas { get; set; }
        [Display(Name = "签名"), MaxLength(20)]
        public string UserName { get; set; }

        [Display(Name = "签名时间")]
        public DateTime? ConfirmTime { get; set; }

    }
}
