using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(Psychology))]
    public class Psychology : Base
    {
        [MaxLength(10)]
        public string Name{get;set;}
        public string Answer { get;set;}
        public int Score { get;set;}

    }
}
