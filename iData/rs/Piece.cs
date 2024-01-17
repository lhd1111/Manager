using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(PersonPiece))]
    public class PersonPiece:Base
    {
        [Display(Name ="工号"),MaxLength(20)]
        public string gh { get; set; }
        [Display(Name ="计件工时"),Column(TypeName = "decimal(5, 2)")]
        public decimal Piece { get; set; }
        [Display(Name = "异常工时"),Column(TypeName = "decimal(5, 2)")]
        public decimal oPiece { get; set; }
        [Display(Name ="计件日期")]
        public DateTime dDate { get; set; }
    }
}
