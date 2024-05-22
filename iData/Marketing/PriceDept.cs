using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace iData.Marketing
{
    [Table(nameof(PriceDept))]
    public class PriceDept:Base
    {
        [Display(Name = "直接人工"), Column(TypeName = "decimal(5, 2)")]
        public float DirectLabor { get; set; }
        [Display(Name = "辅工比例"), Column(TypeName = "decimal(5, 2)")]
        public float AssistWorkerRate { get; set; } = 0;
        [Display(Name = "劳动率"), Column(TypeName = "decimal(5, 2)")]
        public float LaborRate { get; set; }
        [Display(Name = "成型周期"), Column(TypeName = "decimal(5, 2)")]
        public float Period { get; set; }
        [Display(Name = "产品合格率"), Column(TypeName = "decimal(5, 2)")]
        public decimal PassRate { get; set; } = 1;
        [Display(Name = "工装名称"), MaxLength(100)]
        public string FrockName { get; set; }
        [Display(Name = "工装数量")]
        public int FrockNumber { get; set; }
        [Display(Name = "工装金额")]
        public int FrockCost { get; set; }
        [Display(Name = "工时利用率"), Column(TypeName = "decimal(5, 2)")]
        public decimal ManhourRate { get; set; }
        [Display(Name = "机台利用率"), Column(TypeName = "decimal(5, 2)")]
        public decimal MachineRate { get; set; }
        [Display(Name = "各种类型"),MaxLength(5)]
        public string DeptType { get; set; }
        [Display(Name = "机台归属"), MaxLength(20)]
        public string MachineAttr { get; set; }

        [Display(Name = "机台名"), MaxLength(20)]
        public string MachineName { get; set; }
        [Display(Name = "机台值"), Column(TypeName = "decimal(8, 4)")]
        public decimal MachineValue { get; set; }
        [Display(Name ="试验预算")]
        public int Budget { get; set; }
        [Display(Name ="备注")]
        public string DeptNote { get;set; }
        [Display(Name = "行合计"), Column(TypeName = "decimal(12, 4)")]
        public decimal RowSummary { get; set; } = 0;
        public int MachineId { get; set; }
        public int EnumId { get; set; } = 0;

        public int BomId { get; set; }
        public int iGroup{ get; set; }
        public int PriceCollectionId { get; set; }
    }
}
