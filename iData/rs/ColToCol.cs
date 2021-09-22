using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.rs
{
    [Table(nameof(ColToCol))]
    public class ColToCol
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("类名"),MaxLength(50),Required]
        public string Table { get; set; }
        public string Column { get; set; }
        public string OaColumn { get; set; }
        public string rsU8DataBase { get; set; }
    }
}
