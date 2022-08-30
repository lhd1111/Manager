using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.tech
{
    [Table(nameof(Machine))]
    public class Machine:Base
    {
        [Display(Name ="机台号")]
        public int MachineNum { get; set; }
        public string Diameter { get; set; }
        [Display(Name ="机型"),MaxLength(20)]
        public string MachineType { get; set; }
        [Display(Name ="吨位")]
        public int Tone { get; set; }
    }
}
