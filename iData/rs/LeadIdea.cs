using iData.System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace iData.rs
{
    [Table(nameof(LeadIdea))]
    public class LeadIdea:Base
    {
        [Display(Name ="具体意见")]
        public string Idea { get; set; }
        [Display(Name ="判定结果"),MaxLength(5)]
        public string Judge { get; set; }
        [Display(Name ="被判人")]
        public Person Person { get; set; }
        [Display(Name ="判定人")]
        public Account Account { get; set; }
    }
}
