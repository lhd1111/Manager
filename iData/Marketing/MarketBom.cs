using iData.tech;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace iData.Marketing
{
    [Table(nameof(MarketBom))]
    public class MarketBom:TreeBase<MarketBom>
    {
        public string FullName { get; set; }
        public string Photo { get; set; }
        public string Inventory { get; set; }
        [MaxLength(50)]
        public string FsCode { get; set; }
        [MaxLength(60)]
        public string U8Code { get; set; }
        [MaxLength(5), Display(Name = "单位")]
        public string Unit { get; set; }
        [MaxLength(20), Display(Name = "U8生产部门")]
        public string U8Dept { get; set; }
        [MaxLength(20), Display(Name = "U8生产工厂")]
        public string U8Company { get; set; }
        public int iOrder { get; set; }
        [MaxLength(100), Display(Name = "顾客零件号")]
        public string CustomCode { get; set; }
        [Column(TypeName = "decimal(12, 4)")]
        public decimal Number { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal U8Number { get; set; }
        [Column(TypeName = "decimal(8,4)")]
        public decimal Weight { get; set; }
        [MaxLength(100), Display(Name = "毛重")]
        public string GrossWeight { get; set; }
        [MaxLength(100), Display(Name = "颜色")]
        public string Color { get; set; }
        [MaxLength(100), Display(Name = "油漆")]
        public string Paint { get; set; }
        [Display(Name = "表面处理")]
        public string Surface { get; set; }
        [MaxLength(100), Display(Name = "规格")]
        public string Specs { get; set; }
        [MaxLength(100), Display(Name = "供应商零件编号")]
        public string SupplierPartCode { get; set; }
        [MaxLength(50), Display(Name = "模具号")]
        public string Tooling { get; set; }
        [MaxLength(500), Display(Name = "材料")]
        public string Material { get; set; }
        [MaxLength(int.MaxValue), Display(Name = "腔型结构")]
        public string ModleCavity { get; set; }
        //项目关闭时触发
        [Display(Name = "腔型数量")]
        public int ModelNumber { get; set; }
        //[Display(Name = "模具水口料(g)")]
        //public int iModelLost { get; set; }
        //[Display(Name = "产品合格率"), Column(TypeName = "decimal(7, 2)")]
        //public decimal PassRate { get; set; } = 1;

        [MaxLength(5), Display(Name = "自制/外协/标准件")]
        public string MakeMothod { get; set; }
        [MaxLength(100), Display(Name = "标识")]
        public string Characteristic { get; set; }
        [Display(Name = "备注")]
        public string Comments { get; set; }
        [Display(Name = "是否虚拟件")]
        public bool IsVirtual { get; set; } = false;

        public int PriceCollectionId { get; set; }
    }
}
