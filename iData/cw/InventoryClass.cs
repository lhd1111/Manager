using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iData.cw
{
    public class hr_Hi_Person
    {
        [Key]
        public string cInvCCode { get; set; }
        public string cInvCName { get; set; }
        public int iInvCGrades { get; set; }
        public bool bInvCEnd { get; set; }
        public string cEcoCode { get; set; }
        public string cBarCode { get; set; }
        public TimeSpan pubufts { get; set; }
    }
}
