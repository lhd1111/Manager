using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.System
{
    [Table(nameof(TwoEnum))]
    public class TwoEnum:TreeBase<TwoEnum>
    {
        [Display(Name ="名称"),MaxLength(20)]
        public string Name { get; set; }
    }
}
