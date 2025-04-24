using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace iData.tech
{
    [Table("Bom")]
    public class bom
    {
        [Key]
        public int Id { get; set; }
        public int? ParentId { get; set; }
        [MaxLength(50)]
        public string Inventory { get; set; }
        [MaxLength(50)]
        public string FsCode { get; set; }
        [MaxLength(60)]
        public string U8Code { get; set; }
        [MaxLength(5),Display(Name="单位")]
        public string Unit { get; set; }
        [MaxLength(20), Display(Name = "U8生产部门")]
        public string U8Dept { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Scope { get; set; }
        public int Level { get; set; }
        [MaxLength(100)]
        public string Path { get; set; }
        public int iOrder { get; set; }
        public bool IsLeaf { get; set; } = true;
        [MaxLength(100),Display(Name ="顾客零件号")]
        public string CustomCode { get; set; }
        public float Number { get; set; }
        public float U8Number { get; set; }
        public float Weight { get; set; }
        [MaxLength(100), Display(Name = "毛重")]
        public string GrossWeight { get; set; }
        [MaxLength(100), Display(Name = "颜色")]
        public string Color { get; set; }
        [MaxLength(100), Display(Name = "油漆")]
        public string Paint { get; set; }
        [MaxLength(100), Display(Name = "表面处理")]
        public string Surface { get; set; }
        [MaxLength(100), Display(Name = "供应商零件编号")]
        public string SupplierPartCode { get; set; }

        [MaxLength(100), Display(Name = "规格")]
        public string Specs { get; set; }
        [MaxLength(100), Display(Name = "模具号")]
        public string Tooling { get; set; }
        [MaxLength(100), Display(Name = "材料")]
        public string Material { get; set; }
        [MaxLength(100), Display(Name = "腔型结构")]
        public string ModleCavity { get; set; }
        [MaxLength(1), Display(Name = "自制/外协/标准件")]
        public string MakeMothod { get; set; }
        [MaxLength(50), Display(Name = "标识")]
        public string Characteristic { get; set; }
        [Display(Name = "备注")]
        public string Comments { get; set; }
        public virtual bom Parent { get; set; }
        [Display(Name = "是否虚拟件")]
        public bool IsVirtual { get; set; } = false;
        public ICollection<bom> Children { get; set; }

        public int ProjectId{get;set;}
        [ForeignKey(nameof(ProjectId))]

        public virtual Project Project { get; set; }
        
    }
}
