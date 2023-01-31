using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace iData.Marketing
{
    [Table(nameof(PriceCollection))]
    public class PriceCollection:Base
    {
        public int Ver { get; set; }
        public string TaskName { get; set; }
        public string Note { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        [Display(Name = "责任人"), MaxLength(20)]
        public string PersonName { get; set; }
        [Display(Name = "责任人工号"), MaxLength(20)]
        public string PersonGh { get; set; }
        public int requestId { get; set; }
        public int OaApplyId { get; set; }
    }
}
